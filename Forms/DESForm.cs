using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptoLabApp.Forms
{
    public partial class DESForm : Form
    {
        public DESForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileBytes = File.ReadAllBytes(ofd.FileName);
                    using (DES des = DES.Create())
                    {
                        des.Key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                        des.IV = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                        byte[] encrypted = EncryptDES(fileBytes, des.Key, des.IV);
                        File.WriteAllBytes("encrypted.des", encrypted);
                        MessageBox.Show("Файл зашифровано успішно!");
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
                    byte[] fileBytes = File.ReadAllBytes(ofd.FileName);
                    using (DES des = DES.Create())
                    {
                        des.Key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                        des.IV = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
                        byte[] decrypted = DecryptDES(fileBytes, des.Key, des.IV);
                        File.WriteAllBytes("decrypted.txt", decrypted);
                        MessageBox.Show("Файл розшифровано успішно!");
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

        private byte[] DecryptDES(byte[] data, byte[] key, byte[] iv)
        {
            using (DES des = DES.Create())
            {
                des.Key = key;
                des.IV = iv;
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                    }
                    return ms.ToArray();
                }
            }
        }
    }
}