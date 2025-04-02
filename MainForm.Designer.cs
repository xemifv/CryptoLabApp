namespace CryptoLabApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTask1;
        private Button btnTask2;
        private Button btnTask3;
        private Button btnTask4;
        private Button btnTask5;
        private Button btnTask6;
        private Button btnTask7;

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
            this.btnTask1 = new Button();
            this.btnTask2 = new Button();
            this.btnTask3 = new Button();
            this.btnTask4 = new Button();
            this.btnTask5 = new Button();
            this.btnTask6 = new Button();
            this.btnTask7 = new Button();
            this.SuspendLayout();

            // btnTask1
            this.btnTask1.Location = new System.Drawing.Point(50, 20);
            this.btnTask1.Size = new System.Drawing.Size(300, 23);
            this.btnTask1.Text = "Task 1: DES Encryption";
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);

            // btnTask2
            this.btnTask2.Location = new System.Drawing.Point(50, 60);
            this.btnTask2.Size = new System.Drawing.Size(300, 23);
            this.btnTask2.Text = "Task 2: RSA Encryption";
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);

            // btnTask3
            this.btnTask3.Location = new System.Drawing.Point(50, 100);
            this.btnTask3.Size = new System.Drawing.Size(300, 23);
            this.btnTask3.Text = "Task 3: Random Number Generator";
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);

            // btnTask4
            this.btnTask4.Location = new System.Drawing.Point(50, 140);
            this.btnTask4.Size = new System.Drawing.Size(300, 23);
            this.btnTask4.Text = "Task 4: MD5 & SHA-1 Hashing";
            this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);

            // btnTask5
            this.btnTask5.Location = new System.Drawing.Point(50, 180);
            this.btnTask5.Size = new System.Drawing.Size(300, 23);
            this.btnTask5.Text = "Task 5: Digital Signature (RSA)";
            this.btnTask5.Click += new System.EventHandler(this.btnTask5_Click);

            // btnTask6
            this.btnTask6.Location = new System.Drawing.Point(50, 220);
            this.btnTask6.Size = new System.Drawing.Size(300, 23);
            this.btnTask6.Text = "Task 6: RSA Cryptanalysis";
            this.btnTask6.Click += new System.EventHandler(this.btnTask6_Click);

            // btnTask7
            this.btnTask7.Location = new System.Drawing.Point(50, 260);
            this.btnTask7.Size = new System.Drawing.Size(300, 23);
            this.btnTask7.Text = "Task 7: Keylogger & Detector";
            this.btnTask7.Click += new System.EventHandler(this.btnTask7_Click);

            // MainForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Text = "Crypto Lab Application";
            this.Controls.Add(this.btnTask1);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask3);
            this.Controls.Add(this.btnTask4);
            this.Controls.Add(this.btnTask5);
            this.Controls.Add(this.btnTask6);
            this.Controls.Add(this.btnTask7);
            this.ResumeLayout(false);
        }
    }
}