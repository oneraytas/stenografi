using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stenografi
{
    internal class sifrelecoz
    {
        public enum State
        {
            Hiding,
            Filling_With_Zeros
        };
   
        public static Bitmap embedText(string text, Bitmap bmp)
        {
            State state = State.Hiding; // görüntüdeki karakterleri saklamak için
            int charIndex = 0; // gizlenen karakterin indeksini tutar
            int charValue = 0; // inte dönüştürülen karakterin değerini tutar
            long pixelElementIndex = 0;// şu anda işlenmekte olan renk öğesinin (R veya G veya B) dizinini tutar
            int zeros = 0; // işlemi bitirirken eklenen sondaki sıfırların sayısını tutar          
            int R = 0, G = 0, B = 0;// piksel öğelerini tut


            for (int i = 0; i < bmp.Height; i++) // satırları geçme ve işleme
            {
                for (int j = 0; j < bmp.Width; j++)// sutunları geçme işleme

                {
                    // şu anda işlenmekte olan pikseli tutar
                    Color pixel = bmp.GetPixel(j, i);

                    // Her piksel öğesinden en az anlamlı biti (LSB) temizleme
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                    // her piksel için öğelerinden (RGB) geçme
                    for (int n = 0; n < 3; n++)
                    {
                        // yeni 8 bitin işlenip işlenmediğini kontrol eder
                        if (pixelElementIndex % 8 == 0)
                        {
                            // tüm sürecin bitip bitmediğini kontrol et
                            // 8 sıfır eklendiğinde işlem bitti diyebiliriz
                            if (state == State.Filling_With_Zeros && zeros == 8)
                            {
                                // görüntüye son pikseli uygula
                                // öğelerinin yalnızca bir kısmı etkilenmiş olsa bile uygula
                                if ((pixelElementIndex - 1) % 3 < 2)
                                {
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                // metin gizlenmiş olarak bitmap'i döndür
                                return bmp;
                            }

                            // tüm karakterlerin gizlenip gizlenmediğini kontrol eder
                            if (charIndex >= text.Length)
                            {
                                // metnin sonunu işaretlemek için sıfır eklemeye başlar
                                state = State.Filling_With_Zeros;
                            }
                            else
                            {
                                // sonraki karaktere geçin ve tekrar işlem yapma
                                charValue = text[charIndex++];
                            }
                        }

                        // hangi piksel öğesinin LSB'sinde biraz gizleme sırası olduğunu kontrol ediliyor
                        switch (pixelElementIndex % 3)
                        {
                            case 0:
                                {
                                    if (state == State.Hiding)
                                    {
                                        /* karakterdeki en sağdaki bit (charValue % 2) olacaktır.
                                        bu değeri piksel öğesinin LSB'si yerine koymak için, yalnızca buna ekle, 
                                        piksel öğesinin LSB'sinin bu işlemden önce temizler
                                        */

                                        R += charValue % 2;

                                      
                                        // karakterin eklenen en sağdaki bitini kaldırır, 
                                        //böylece bir dahaki sefere bir sonrakine ulaşabiliriz
                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    if (state == State.Hiding)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    if (state == State.Hiding)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }

                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                break;
                        }

                        pixelElementIndex++;

                        if (state == State.Filling_With_Zeros)
                        {
                            // sıfırların değerini 8 olana kadar artır
                            zeros++;
                        }
                    }
                }
            }

            return bmp;
        }

        public static string extractText(Bitmap bmp)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            // görüntüden çıkarılacak metni tutar
            string extractedText = String.Empty;

            // satırlardan geçer
            for (int i = 0; i < bmp.Height; i++)
            {
                // her satırdan geçer
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color pixel = bmp.GetPixel(j, i);

                    // her piksel için öğelerinden (RGB) geçme
                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    /* piksel öğesinden LSB'yi alın (pixel.R % 2 olacaktır), 
                                     * ardından mevcut karakterin sağına bir bit ekleyin. 
                                     * bu, (charValue = charValue * 2) eklenen biti 
                                     * (bu değer varsayılan olarak 0'dır) piksel öğesinin 
                                     * LSB'si ile değiştirerek yapılabilir.
                                    */
                                    
                                    charValue = charValue * 2 + pixel.R % 2;
                                }
                                break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                }
                                break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                }
                                break;
                        }

                        colorUnitIndex++;

                        // 8 bit eklenmişse, geçerli karakteri sonuç metnine ekle
                        if (colorUnitIndex % 8 == 0)
                        {
                            // süreç daha önce gerçekleşmişti tersi alınıyor
                            charValue = reverseBits(charValue);

                            // Durma karakteri ise sadece 0 olabilir (8 sıfır)
                            if (charValue == 0)
                            {
                                return extractedText;
                            }

                            // ckarakter değerini int'den char'a çevir
                            char c = (char)charValue;

                            // geçerli karakteri sonuç metnine ekle
                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }

        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }
    }
}
