using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Encrypt2
{
    public class Class1
    {
        private static byte[] StringToByteArray(string hex)// This is string to ByteArray which converts the string type to bytes which will be used for Encryption/Decryption
        {
            hex = hex.Replace("-", "");
            byte[] byteArray = new byte[hex.Length / 2];
            for (int i = 0; i < byteArray.Length; i++)// Traverse the array to convert the string in Key and IV.
            {
                byteArray[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return byteArray;
        }
        private static readonly byte[] Key = StringToByteArray("5E-55-5C-93-C2-DA-3D-9A-6B-53-BF-71-4A-40-46-0B-1C-37-50-78-E5-52-FB-D6-16-18-36-50-E3-D4-00-2A");// this is a 32 byte Key for Encryption/Decryption
        private static readonly byte[] IV  = StringToByteArray("7C-CD-BF-B3-8B-08-F6-20-82-1C-B8-1E-C8-96-04-EB");//This is a 16 Bytes IV for Encryption/Decryption


        public static string EncryptString(string pwdInput)
        {
            var aes = Aes.Create();// create a AES object instance
            aes.Key = Key;// use the aes key and Intialization Vector to encrypt the data
            aes.IV = IV;
            //aes.Padding = PaddingMode.PKCS7;// Make sure that the padding is default PKCS7

            var encrypted = aes.CreateEncryptor(aes.Key, aes.IV);// use the random key and IV to Encrypt

            var plainBytes = Encoding.UTF8.GetBytes(pwdInput);//get the string you want to encrypt
            var encryptedBytes = encrypted.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

            return Convert.ToBase64String(encryptedBytes);// returns the encrypted bytes
        }

        public static string DecryptString(string encryptedText)// Now create a Decrypt class to decrypt the password
        {
            var aes = Aes.Create();
            aes.Key = Key;//use the key and IV to Decrypt the Encrypted Data
            aes.IV = IV;
            //aes.Padding = PaddingMode.PKCS7;// Make sure that the padding is default PKCS7

            var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);// use the same Key and IV used in Encrpyt data to use and decrypt the text

            var encryptedBytes = Convert.FromBase64String(encryptedText);// take the encyrpted bytes as input
            var decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

            return Encoding.UTF8.GetString(decryptedBytes);// return thee decrypted text
        }
        private static byte[] GenerateRandomKey(int size)
        {
            using (var rng = new RNGCryptoServiceProvider())// Generates a Random 32 bit key using RNGCryptoService
            {
                var key = new byte[size];
                rng.GetBytes(key);
                return key;
            }
        }
        private static byte[] GenerateRandomIV(int size)//Generates a Random IV for the key using RNGCryptoService
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var iv = new byte[size];
                rng.GetBytes(iv);
                return iv;
            }
        }



    }
}