using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptoLabApp.Forms
{
    public partial class RSAForm : Form
    {
        private RSA rsa; // Зберігаємо об'єкт RSA для повторного використання ключів

        public RSAForm()
        {
            rsa = RSA.Create(2048); // Ініціалізуємо RSA з ключем 2048 біт
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileBytes = File.ReadAllBytes(ofd.FileName);

                    // Обмежуємо розмір даних для RSA (макс. 245 байт для 2048-бітного ключа з PKCS1)
                    byte[] dataToEncrypt = fileBytes.Length > 245 ? new byte[245] : fileBytes;
                    if (fileBytes.Length > 245)
                    {
                        Array.Copy(fileBytes, dataToEncrypt, 245);
                    }

                    // Шифрування RSA
                    var rsaStopwatch = Stopwatch.StartNew();
                    byte[] encryptedRSA = rsa.Encrypt(dataToEncrypt, RSAEncryptionPadding.Pkcs1);
                    rsaStopwatch.Stop();
                    File.WriteAllBytes("encrypted.rsa", encryptedRSA);

                    // Шифрування DES для порівняння
                    using (DES des = DES.Create())
                    {
                        des.Key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                        des.IV = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                        var desStopwatch = Stopwatch.StartNew();
                        byte[] encryptedDES = EncryptDES(dataToEncrypt, des.Key, des.IV);
                        desStopwatch.Stop();

                        // Виведення результатів порівняння
                        MessageBox.Show($"RSA: {rsaStopwatch.ElapsedMilliseconds} мс\nDES: {desStopwatch.ElapsedMilliseconds} мс\nФайл зашифровано RSA!");
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] encryptedBytes = File.ReadAllBytes(ofd.FileName);
                    try
                    {
                        byte[] decrypted = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.Pkcs1);
                        File.WriteAllBytes("decrypted.txt", decrypted);
                        MessageBox.Show("Файл розшифровано успішно!");
                    }
                    catch (CryptographicException ex)
                    {
                        MessageBox.Show($"Помилка розшифрування: {ex.Message}");
                    }
                }
            }
        }

        private byte[] EncryptDES(byte[] data, byte[] key, byte[] iv)
        {
            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                    }
                    return ms.ToArray();
                }
            }
        }
    }
}