using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Program
    {
        public static string HashPassword(string password)
        {
            // Generate a salt
            string salt = BCrypt.Net.BCrypt.GenerateSalt();

            // Hash the password with the salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            return hashedPassword;
        }

        // Verifies if a password matches its hashed version
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Use BCrypt to verify the password
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }


        public static void EncryptFile(string inputFile, string outputFile, string key)
        {
            FileStream fs;
            using (FileStream inputStream = File.Open(inputFile, FileMode.Open))
            using (FileStream outputStream = File.Create(outputFile))
            {
                byte[] keyBytes = Convert.FromBase64String(key);
                byte[] iv = new byte[16]; // Initialization Vector
                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;
                    aes.IV = iv;

                    // Encrypt the file
                    using (CryptoStream cryptoStream = new CryptoStream(outputStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        inputStream.CopyTo(cryptoStream);
                    }
                    fs = outputStream;
                }
            }


        }

        public static void DecryptFile(string inputFile, string outputFile, string key)
        {
            using (FileStream inputStream = File.Open(inputFile, FileMode.Open))
            using (FileStream outputStream = File.Create(outputFile))
            {
                byte[] keyBytes = Convert.FromBase64String(key);
                byte[] iv = new byte[16]; // Initialization Vector
                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;
                    aes.IV = iv;

                    // Decrypt the file
                    using (CryptoStream cryptoStream = new CryptoStream(inputStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(outputStream);
                    }
                }
            }
        }

        public static string GenerateBase64Key(int keySize)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] keyBytes = new byte[keySize / 8];
                rng.GetBytes(keyBytes);
                return Convert.ToBase64String(keyBytes);
            }
        }



        public static string EncryptFileStreamToString(Stream inputStream, string key)
        {
            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] iv = new byte[16]; // Initialization Vector

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = iv;

                using (MemoryStream encryptedStream = new MemoryStream())
                {
                    // Encrypt the stream
                    using (CryptoStream cryptoStream = new CryptoStream(encryptedStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        inputStream.CopyTo(cryptoStream);
                    }

                    // Get the encrypted data as a byte array
                    byte[] encryptedBytes = encryptedStream.ToArray();

                    // Convert the encrypted bytes to a base64-encoded string
                    return Convert.ToBase64String(encryptedBytes);
                }
            }
        }

        public static string DecryptString(string encryptedString, string key)
        {
            byte[] keyBytes = Convert.FromBase64String(key);
            byte[] iv = new byte[16]; // Initialization Vector
            byte[] encryptedBytes = Convert.FromBase64String(encryptedString);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.IV = iv;

                using (MemoryStream decryptedStream = new MemoryStream())
                {
                    // Decrypt the encrypted data
                    using (CryptoStream cryptoStream = new CryptoStream(decryptedStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                    }

                    // Get the decrypted data as a byte array
                    byte[] decryptedBytes = decryptedStream.ToArray();

                    // Convert the decrypted bytes to a string
                    return Encoding.UTF8.GetString(decryptedBytes);
                }
            }
        }

        static void Main(string[] args)
        {

            var data = new SortedList<string, int>();

            data.Add("amol", 10);
            data.Add("zzzzz", 1);
            data.Add("anmol", 50);
            data.Add("zzzz", 0);


            var password = "writtenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwrittenwritten";

            //var hp = HashPassword(password);
            var hp = "$2a$10$TGlusiK5uQyZzNZutowvt.p38CTWfWQtnPw4Vo.I0orLJwinhWeXm";

            var isValidPwd = VerifyPassword(password, hp);


            string inputFile = @"C:\AmolWabale\Storage Temp\SFTP using Private Key\trial_passphrase.ppk";
            string encryptedFile = @"C:\AmolWabale\Storage Temp\SFTP using Private Key\trial_passphrase_enc.ppk";
            string decrypttedFile = @"C:\AmolWabale\Storage Temp\SFTP using Private Key\trial_passphrase_decry.ppk";
            string key = password; // Replace this with your encryption key
            //key = GenerateBase64Key(256);
            key = "ZNvfNJHd7kA0XG5IMqlTHGxdVdA0NjOablsq/2I8NOs=";
            //EncryptFile(inputFile, encryptedFile, key);
            //DecryptFile(encryptedFile, decrypttedFile, key);

            string decryptedString = "";
            //inputFile = @"C:\AmolWabale\Storage Temp\SFTP using Private Key\txtdoc.txt";
            //encryptedFile = @"C:\AmolWabale\Storage Temp\SFTP using Private Key\txtdoc_enc.txt";

            string inputStream = File.ReadAllText(encryptedFile);
            

                //string encryptedString = EncryptFileStreamToString(inputStream, key);
                //Console.WriteLine("Encrypted String: " + encryptedString);
                //File.WriteAllText(encryptedFile, encryptedString);
                
                decryptedString = DecryptString(inputStream, key);
                Console.WriteLine("Decrypted String: " + decryptedString);
                File.WriteAllText(decrypttedFile, decryptedString);

            


        }
    }
}
