namespace CryptoLabApp.Forms
{
    partial class RandomNumberForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnGenerate;

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
            this.btnGenerate = new Button();
            this.SuspendLayout();

            // btnGenerate
            this.btnGenerate.Location = new System.Drawing.Point(20, 20);
            this.btnGenerate.Size = new System.Drawing.Size(150, 23);
            this.btnGenerate.Text = "Generate & Check Prime";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);

            // RandomNumberForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Text = "Random Number Generator";
            this.Controls.Add(this.btnGenerate);
            this.ResumeLayout(false);
        }
    }
}