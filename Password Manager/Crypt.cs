using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    internal class Crypt
    {
        internal static string HashKey(string key)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] hashed = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
                return Convert.ToBase64String(hashed);
            }


        }
        
        private byte[][] GetHashKeys(string key)
        {
            byte[][] result = new byte[2][];
           

            SHA256 sha256 = SHA256.Create();

            byte[] rawKey = Encoding.UTF8.GetBytes(key);
            byte[] rawIV = Encoding.UTF8.GetBytes(key);

            byte[] hashKey = sha256.ComputeHash(rawKey);
            byte[] hashIV = sha256.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            result[0] = hashKey;
            result[1] = hashIV;

            return result;
        }
        internal string Encrypt(string key, string data)
        {
            string encrypted = null;
            byte[][] keys = GetHashKeys(key);

            try
            {
                encrypted = EncryptStringToBytes_Aes(data, keys[0], keys[1]);
            }
            catch { }
              
            return encrypted;
        }

        internal string Decrypt(string key, string data)
        {
            string decrypted = null;
            byte[][] keys = GetHashKeys(key);
           

            try
            {
                decrypted = DecryptStringFromBytes_Aes(data, keys[0], keys[1]);
            }
            catch { }

            return decrypted;
        }
        static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return Convert.ToBase64String(encrypted);
        }

        static string DecryptStringFromBytes_Aes(string cipherTextString, byte[] Key, byte[] IV)
        {
            byte[] cipherText = Convert.FromBase64String(cipherTextString);
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
