using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Stenografi
{
    public class kripto
    {
        // AES ŞİFRELEME :
        // AES ŞİFRELEME :
        // AES ŞİFRELEME :
        // AES ŞİFRELEME :
        // AES ŞİFRELEME :
        // https://github.com/Digiex/MCLauncher.NET/blob/master/MCLauncher.net/Crypto.cs

        private static byte[] _salt = Encoding.ASCII.GetBytes("jasdh7834y8hfeur73rsharks214");

        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        public static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException("plainText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            string outStr = null;                       // Encrypted string to return
            RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create a RijndaelManaged object
                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                // Create a decryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // prepend the IV
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException("cipherText");
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException("sharedSecret");

            // Declare the RijndaelManaged object
            // used to decrypt the data.
            RijndaelManaged aesAlg = null;

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                // Create the streams used for decryption.                
                byte[] bytes = Convert.FromBase64String(cipherText);
                using (MemoryStream msDecrypt = new MemoryStream(bytes))
                {
                    // Create a RijndaelManaged object
                    // with the specified key and IV.
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    // Get the initialization vector from the encrypted stream
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    // Create a decrytor to perform the stream transform.
                    ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                    }
                }
            }
            finally
            {
                // Clear the RijndaelManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }

            return plaintext;
        }

        private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        
        
        }
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************

        //SEZAR ŞİFRELEME 
        //SEZAR ŞİFRELEME 
        //SEZAR ŞİFRELEME 
        //SEZAR ŞİFRELEME 
        //SEZAR ŞİFRELEME 
        //https://stackoverflow.com/questions/62206015/include-all-printable-characters-in-caesar-cipher-ascii-32-126

        private static char CipherSezar(char ch, int key)
        {
            if (char.IsControl(ch))
                return ch;

            char offset = ' ';
            return (char)((((ch + key) - offset) % 95) + offset);
        }
        public static string EncipherSezar(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += CipherSezar(ch, key);

            return output;
        }

        public static string DecipherSezar(string input, int key)
        {
            return EncipherSezar(input, 95 - key);
        }
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        //3DES ŞİFRELEME
        //3DES ŞİFRELEME
        //3DES ŞİFRELEME
        //https://foxlearn.com/windows-forms/encryption-and-decryption-using-triple-des-in-csharp-376.html

        public static string DESEncrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
        public static string DESDecrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] byteBuff = Convert.FromBase64String(encrypt);
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }

        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // RSA 
        // RSA
        // RSA
        //https://developpaper.com/c-rsa-encryption-and-decryption/
        //https://superdry.apphb.com/tools/online-rsa-key-converter
        //https://travistidwell.com/jsencrypt/demo/

        private static string publicKey = "<RSAKeyValue><Modulus>mAAxHCO+vLnRscsNLzxS0nHMy+xCeG52Z2gVL8IfKak32bk0Pddp6ssWcxdXlJMColapHfixfOtvES21H4W3ivfajWFPczHRociD9oEfC62Gg2hWxgpBYxkw24S6pvHi2VAA44qHlRAgTr+CvvYI8HyAHP8GGoxPw0TfdwGdCfdMpbHrtk5BcqcgFglBPEtp1Jm8lLsgUDxptXrCKht0wUK+GFcdcZi+Kr+XXO58BjSoY6NcFzIg5K/m9rltXo2LIwZRarZSgRlD3TM6FOpjn4RAeb1mkxRLTbry47VQiRZFcOgMT49xewk4KOAQrtSKNUCpY6fIRpk9R3EfgsjGlQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";// = "generate key ile ürettikten sonra buraya tamamını yapıştırın.";
        private static string privateKey = "<RSAKeyValue><Modulus>mAAxHCO+vLnRscsNLzxS0nHMy+xCeG52Z2gVL8IfKak32bk0Pddp6ssWcxdXlJMColapHfixfOtvES21H4W3ivfajWFPczHRociD9oEfC62Gg2hWxgpBYxkw24S6pvHi2VAA44qHlRAgTr+CvvYI8HyAHP8GGoxPw0TfdwGdCfdMpbHrtk5BcqcgFglBPEtp1Jm8lLsgUDxptXrCKht0wUK+GFcdcZi+Kr+XXO58BjSoY6NcFzIg5K/m9rltXo2LIwZRarZSgRlD3TM6FOpjn4RAeb1mkxRLTbry47VQiRZFcOgMT49xewk4KOAQrtSKNUCpY6fIRpk9R3EfgsjGlQ==</Modulus><Exponent>AQAB</Exponent><P>5BwMJ3sz00BjiYB+BxExazQE0BeUf33+tMqBy05iKoS+LWMlEWlXwI/ysqdC+VxQfHY5+9uCakNiZQTuRA7MM+MDavTRzOZdDDNOYyFX5kvjRcnWK/htZHFL4S8bRiBif/hWWEntpdpLiVLnVzdcQPrZarIeeVFMTNSNg29mNJk=</P><Q>qpXlvoOZqlfHIqIKbPPsp/qd8teNTv4QDnKZZdKOPum5lnhaYcNHLgr5FcDtKOiHVS0nZn5EfW1kjzgkoK7b0lGoQB9bmL8V5IVc5faRWMs3gyjtqadZE8WFKs/e71b8MoPUpHayee2y/xzDFoaWE7KusyJu/ZM17lCdj3ik410=</Q><DP>Q1qAwDuhntPZUCVvkPijperTLPp5b3eteIZ+8p/vXmyZlt86d7yqG4Klf9jhbq2yWj2ye0piZKwG5pshG1lfNEbooHEvbZfri4musJiM0sQ/lEC3i34sFsdZR2FYZUl0rCKQpDsX/6vIOAERq+/9vnYTMmzrkJjPtbPhIRkIjak=</DP><DQ>ZgCEBEuE00rxlE/4k/W3iSpe0Br8MEPTLhBwkWY6EHyJsOP+h37RTULadpuKNG/2nIQHj03pfmavPsR/gmWMpFKXnOAjUU7RtHfaeNfbSZEafJ84nb2nkh8F5feugscsvrf9quofBrGP2uRD83A+xUCPHiZ038Pq97nUvTmSvzE=</DQ><InverseQ>yF92Dkb9nUMNfQOUGOPejbJJ0CQ+Mr5F6Vk7uwadrOPM2H+6Ca0n2NoY68UISZNWFm9ttYnO5bEyGi98va2Jc9l30AEpiMxC+9PDDOaBcmU7wYN/TaAWRJzXsz11RZNqeEPuss4gOPhNnw72uouKDgK1xssHmVIfF4h5e+HrrLU=</InverseQ><D>A80lbUW7lG61PtQMLV092QN9krAC7Y4dqfJhbUNWki0oN2q5Ur6baILRuekgiJewniy6qAQ7NBuTOIPDHtmyQGh4b8a6PPBHBNvF6RlLlHgvgAPQ/7zr67WKkkLchCZSfQrSKt6hC2pO1IlXlL0Edjc24QLDvVA7AnArgodozQH3USxBOFihDUrFf5Z+C14354ior6qI8Fx/6EzDjM4lx1lKLtFZ8cWpmjg62cYU6pAO0toTi9gtow21XE0854E19NwRguKDwe6D78ryjPFFX5/7nEWLiXotyEnrO1cukx/bLgG4bOOxUF/5CxG7VHjjy9QisV6AIIrgw8iqsggCYQ==</D></RSAKeyValue>";// = "generate key ile ürettikten sonra buraya tamamını yapıştırın.";
       
        
        public static string RSAEncrypt(string strText)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKey);

            byte[] byteText = Encoding.UTF8.GetBytes(strText);
            byte[] byteEntry = rsa.Encrypt(byteText, false);

            return Convert.ToBase64String(byteEntry);
        }


        public static string RSADecrypt(string strEntryText)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKey);

            byte[] byteEntry = Convert.FromBase64String(strEntryText);
            byte[] byteText = rsa.Decrypt(byteEntry, false);

            return Encoding.UTF8.GetString(byteText);
        }

        // RSA
        //
        //https://paste.laravel.io/5d5a451c-852c-4d0b-9f47-7923c1de98ce
        //YEDEK YEDEK
        /*
        public enum KeySizes
        {
            SIZE_512 = 512,
            SIZE_1024 = 1024,
            SIZE_2048 = 2048,
            SIZE_952 = 952,
            SIZE_1369 = 1369
        };

        /*
         KEY ÜRETMEK GEREKİRSE BU ALANI KULLAN VEYA WEBTE PEM TO XML İLE AL 

        private static void generateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048))
            {
                rsa.PersistKeyInCsp = false;

                publicKey = rsa.ToXmlString(false);
                
                Console.WriteLine(publicKey);
                privateKey = rsa.ToXmlString(true);
                Console.WriteLine(privateKey);
               
            }
        }*/
        /*
       public static byte[] RSAEncrypt(byte[] input)
       {

           byte[] encrypted;
           using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048))
           {
               rsa.PersistKeyInCsp = false;
               rsa.FromXmlString(publicKey);
               encrypted = rsa.Encrypt(input, true);
           }
           return encrypted;
       }
       public static byte[] encrypted2;
       public static string RSAsifre(string message)
       {
           byte[] encrypted = RSAEncrypt(Encoding.UTF8.GetBytes(message));
           encrypted2 = encrypted;
           return BitConverter.ToString(encrypted).Replace("-", "");

       }
       public static string RSAcoz(string message)
       {

           byte[] decrypted = RSADecrypt(encrypted2);
           return Encoding.UTF8.GetString(decrypted);
       }
       public static byte[] RSADecrypt(byte[] input)
       {
           byte[] decrypted;
           using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048))
           {
               rsa.PersistKeyInCsp = false;
               rsa.FromXmlString(privateKey);
               decrypted = rsa.Decrypt(input, true);
           }
           return decrypted;
       }
       */

        // ************************************************************
        // ************************************************************
        // ************************************************************
        // ************************************************************
        // Vigenere 
        // Vigenere
        // Vigenere
        //https://www.programmingalgorithms.com/algorithm/vigenere-cipher/

        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        public static string Cipher(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null; // Error

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }

        public static string VigEncipher(string input, string key)
        {
            return Cipher(input, key, true);
        }

        public static string VigDecipher(string input, string key)
        {
            return Cipher(input, key, false);
        }



        ////////////////////// SON ////////////////////////
    }

}


