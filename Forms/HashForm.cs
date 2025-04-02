using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptoLabApp.Forms
{
    public partial class HashForm : Form
    {
        public HashForm()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileBytes = File.ReadAllBytes(ofd.FileName);

                    var md5Stopwatch = Stopwatch.StartNew();
                    string md5Hash = ComputeHash(fileBytes, MD5.Create());
                    md5Stopwatch.Stop();

                    var sha1Stopwatch = Stopwatch.StartNew();
                    string sha1Hash = ComputeHash(fileBytes, SHA1.Create());
                    sha1Stopwatch.Stop();

                    MessageBox.Show($"MD5: {md5Hash}\nЧас: {md5Stopwatch.ElapsedMilliseconds} мс\nSHA-1: {sha1Hash}\nЧас: {sha1Stopwatch.ElapsedMilliseconds} мс");
                }
            }
        }

        private string ComputeHash(byte[] data, HashAlgorithm algorithm)
        {
            byte[] hash = algorithm.ComputeHash(data);
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}