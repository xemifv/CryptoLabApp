using System;
using System.Numerics;
using System.Windows.Forms;

namespace CryptoLabApp.Forms
{
    public partial class RSACryptanalysisForm : Form
    {
        public RSACryptanalysisForm()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            BigInteger exponent = 5;
            BigInteger modulus = 19;
            BigInteger ciphertext = 95;

            BigInteger message = KeylessReadingRSA(ciphertext, exponent, modulus);
            MessageBox.Show($"Розшифроване повідомлення: {message}");
        }

        private BigInteger KeylessReadingRSA(BigInteger C, BigInteger e, BigInteger n)
        {
            BigInteger Ce = C;
            for (int j = 1; j < 10; j++)
            {
                Ce = BigInteger.ModPow(Ce, e, n);
                if (Ce == C)
                {
                    return BigInteger.ModPow(C, BigInteger.Pow(e, j - 1), n);
                }
            }
            return -1; // анлучка 
        }
    }
}