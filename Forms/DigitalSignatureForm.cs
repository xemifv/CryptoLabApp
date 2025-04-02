using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptoLabApp.Forms
{
    public partial class DigitalSignatureForm : Form
    {
        private RSA rsa = RSA.Create(2048);

        public DigitalSignatureForm()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileBytes = File.ReadAllBytes(ofd.FileName);
                    byte[] signature = rsa.SignData(fileBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                    File.WriteAllBytes("signature.sig", signature);
                    MessageBox.Show("Файл підписано успішно!");
                }
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdFile = new OpenFileDialog())
            {
                if (ofdFile.ShowDialog() == DialogResult.OK)
                {
                    using (OpenFileDialog ofdSig = new OpenFileDialog())
                    {
                        if (ofdSig.ShowDialog() == DialogResult.OK)
                        {
                            byte[] fileBytes = File.ReadAllBytes(ofdFile.FileName);
                            byte[] signature = File.ReadAllBytes(ofdSig.FileName);
                            bool verified = rsa.VerifyData(fileBytes, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                            MessageBox.Show($"Підпис перевірено: {verified}");
                        }
                    }
                }
            }
        }
    }
}