using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stenografi
{
    public partial class stenosifre : Form
    {

        private Bitmap bmp = null;
        private string extractedText = string.Empty;
        public stenosifre()
        {
            InitializeComponent();
        }

        private void stenosifre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 cagir = new Form1();
            cagir.Show();
            this.Hide();
        }

        private void ekle_Click(object sender, EventArgs e)
        {

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
            open_dialog.InitialDirectory = @"C:\";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                resimkutusu.Image = Image.FromFile(open_dialog.FileName);
                resimyol.Text = open_dialog.FileName.ToString();
                sifrele.Enabled = true;
                mesaj.Enabled = true;
            }



        }

        private void sifrele_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)resimkutusu.Image;

            string text = mesaj.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("Şifrelemek İstediğiniz Metin Boş Olamaz !!", "Hata");

                return;
            }
            // Aes Şifreleme
            if (sifrecombo.SelectedIndex==3)
            {
                if (sifretxt.Text.Length < 6)
                {
                    MessageBox.Show("Lütfen en az 6 karakterden oluşan bir şifre giriniz", "Hata");

                    return;
                }
                else
                {
                    text = kripto.EncryptStringAES(text, sifretxt.Text);
                }
            }
            //Sezar Şifreleme
            if (sifrecombo.SelectedIndex == 0)
            {
                try
                {
                    text = kripto.EncipherSezar(text, (int.Parse(sifretxt.Text)%95));
                }
                catch
                {
                    MessageBox.Show("Hata !! Sayı Girin");

                    return;
                }
            }
            //Vigenere
              if (sifrecombo.SelectedIndex == 1)
            {
                try
                {
                    text = kripto.VigEncipher(text, sifretxt.Text);
                }
                catch
                {
                    MessageBox.Show("Hata !!");

                    return;
                }
            }
            //3DES
            if (sifrecombo.SelectedIndex == 2)
            {
                try
                {
                    text = kripto.DESEncrypt(text, sifretxt.Text);
                }
                catch
                {
                    MessageBox.Show("Hata !! ");

                    return;
                }
            }
            if (sifrecombo.SelectedIndex == 4)
            {
                try
                {
                    text = kripto.RSAEncrypt(text);
                }
                catch
                {
                    MessageBox.Show("Hata !! ");

                    return;
                }



            }
            //ŞİFRE RESİME GÖMME ALANI 
            bmp = sifrelecoz.embedText(text, bmp);

                MessageBox.Show("Metniniz görsele başarıyla gizlendi, Lütfen Resmi Kaydedin !");




                SaveFileDialog save_dialog = new SaveFileDialog();
                save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";
                save_dialog.InitialDirectory = @"C:\";
                if (save_dialog.ShowDialog() == DialogResult.OK)
                {
                    switch (save_dialog.FilterIndex)
                    {
                        case 0:
                            {
                                bmp.Save(save_dialog.FileName, ImageFormat.Png);
                            }
                            break;
                        case 1:
                            {
                                bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                            }
                            break;
                    }


                }

            }

        private void kriptoloji_CheckedChanged(object sender, EventArgs e)
        {
            if (kriptoloji.Checked)
            {
                sifrecombo.Enabled = true;
            }
            else
            {
                sifrecombo.Enabled = false;
                sifretxt.Visible = false;
                label3.Visible = false;
            }
        }

        private void sifrecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sifrecombo.SelectedIndex == 0)
            {
                label3.Text = "Şifre";
                sifretxt.Text = "Kaydırılacak Sayıyı Girin";
                sifretxt.Visible = true; label3.Visible = true;
            }
            
            if (sifrecombo.SelectedIndex == 1)
            {
                label3.Text = "Şifre;"; 
                sifretxt.Text = "Metin Girin";
                sifretxt.Visible = true; label3.Visible = true;
            }
            
            if (sifrecombo.SelectedIndex == 2)
            {
                label3.Text = "Şifre;";
                sifretxt.Text = "En az 6 Karakter Girin";
                sifretxt.Visible = true; label3.Visible = true;
            }  //3des
            if (sifrecombo.SelectedIndex == 3)
            {
                label3.Text = "Şifre;";
                sifretxt.Text = "En az 6 Karakter Girin";
                sifretxt.Visible = true; label3.Visible = true;
            }// AES
            if (sifrecombo.SelectedIndex == 4)
            {
                label3.Text = "Public Key(XML);";
                sifretxt.Text = "< RSAKeyValue >< Modulus > mAAxHCO + vLnRscsNLzxS0nHMy + xCeG52Z2gVL8IfKak32bk0Pddp6ssWcxdXlJMColapHfixfOtvES21H4W3ivfajWFPczHRociD9oEfC62Gg2hWxgpBYxkw24S6pvHi2VAA44qHlRAgTr + CvvYI8HyAHP8GGoxPw0TfdwGdCfdMpbHrtk5BcqcgFglBPEtp1Jm8lLsgUDxptXrCKht0wUK + GFcdcZi + Kr + XXO58BjSoY6NcFzIg5K / m9rltXo2LIwZRarZSgRlD3TM6FOpjn4RAeb1mkxRLTbry47VQiRZFcOgMT49xewk4KOAQrtSKNUCpY6fIRpk9R3EfgsjGlQ ==</ Modulus >< Exponent > AQAB </ Exponent ></ RSAKeyValue > ";
                sifretxt.Visible = true; label3.Visible = true;
            }//RSA
        }
    }
    }



