namespace CryptoLabApp.Forms
{
    partial class RSACryptanalysisForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAnalyze;

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
            this.btnAnalyze = new Button();
            this.SuspendLayout();

            // btnAnalyze
            this.btnAnalyze.Location = new System.Drawing.Point(20, 20);
            this.btnAnalyze.Size = new System.Drawing.Size(150, 23);
            this.btnAnalyze.Text = "Analyze Ciphertext";
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);

            // RSACryptanalysisForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Text = "RSA Cryptanalysis";
            this.Controls.Add(this.btnAnalyze);
            this.ResumeLayout(false);
        }
    }
}