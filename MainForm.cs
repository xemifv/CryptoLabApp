using System;
using System.Windows.Forms;
using CryptoLabApp.Forms;

namespace CryptoLabApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, EventArgs e)
        {
            new DESForm().ShowDialog();
        }

        private void btnTask2_Click(object sender, EventArgs e)
        {
            new RSAForm().ShowDialog();
        }

        private void btnTask3_Click(object sender, EventArgs e)
        {
            new RandomNumberForm().ShowDialog();
        }

        private void btnTask4_Click(object sender, EventArgs e)
        {
            new HashForm().ShowDialog();
        }

        private void btnTask5_Click(object sender, EventArgs e)
        {
            new DigitalSignatureForm().ShowDialog();
        }

        private void btnTask6_Click(object sender, EventArgs e)
        {
            new RSACryptanalysisForm().ShowDialog();
        }

        private void btnTask7_Click(object sender, EventArgs e)
        {
            new KeyloggerForm().ShowDialog();
        }
    }
}