namespace CryptoLabApp.Forms
{
    partial class HashForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnHash;

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
            this.btnHash = new Button();
            this.SuspendLayout();

            // btnHash
            this.btnHash.Location = new System.Drawing.Point(20, 20);
            this.btnHash.Size = new System.Drawing.Size(100, 23);
            this.btnHash.Text = "Hash File";
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);

            // HashForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 100);
            this.Text = "MD5 & SHA-1 Hashing";
            this.Controls.Add(this.btnHash);
            this.ResumeLayout(false);
        }
    }
}