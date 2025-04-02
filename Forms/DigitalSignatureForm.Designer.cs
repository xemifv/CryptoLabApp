namespace CryptoLabApp.Forms
{
    partial class DigitalSignatureForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSign;
        private Button btnVerify;

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
            this.btnSign = new Button();
            this.btnVerify = new Button();
            this.SuspendLayout();

            // btnSign
            this.btnSign.Location = new System.Drawing.Point(20, 20);
            this.btnSign.Size = new System.Drawing.Size(100, 23);
            this.btnSign.Text = "Sign File";
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);

            // btnVerify
            this.btnVerify.Location = new System.Drawing.Point(130, 20);
            this.btnVerify.Size = new System.Drawing.Size(100, 23);
            this.btnVerify.Text = "Verify Signature";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);

            // DigitalSignatureForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 100);
            this.Text = "Digital Signature (RSA)";
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnVerify);
            this.ResumeLayout(false);
        }
    }
}