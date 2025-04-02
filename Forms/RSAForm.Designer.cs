namespace CryptoLabApp.Forms
{
    partial class RSAForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnEncrypt;
        private Button btnDecrypt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEncrypt = new Button();
            this.btnDecrypt = new Button();
            this.SuspendLayout();

            // btnEncrypt
            this.btnEncrypt.Location = new System.Drawing.Point(20, 20);
            this.btnEncrypt.Size = new System.Drawing.Size(100, 23);
            this.btnEncrypt.Text = "Encrypt File";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // btnDecrypt
            this.btnDecrypt.Location = new System.Drawing.Point(130, 20);
            this.btnDecrypt.Size = new System.Drawing.Size(100, 23);
            this.btnDecrypt.Text = "Decrypt File";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // RSAForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 100);
            this.Text = "RSA Encryption/Decryption";
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.ResumeLayout(false);
        }
    }
}