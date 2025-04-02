namespace CryptoLabApp.Forms
{
    partial class KeyloggerForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStart;
        private Button btnStop;
        private Button btnDetect;

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
            this.btnStart = new Button();
            this.btnStop = new Button();
            this.btnDetect = new Button();
            this.SuspendLayout();

            // btnStart
            this.btnStart.Location = new System.Drawing.Point(20, 20);
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.Text = "Start Keylogger";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // btnStop
            this.btnStop.Location = new System.Drawing.Point(130, 20);
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.Text = "Stop Keylogger";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);

            // btnDetect
            this.btnDetect.Location = new System.Drawing.Point(240, 20);
            this.btnDetect.Size = new System.Drawing.Size(100, 23);
            this.btnDetect.Text = "Detect & Delete";
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);

            // KeyloggerForm
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 100);
            this.Text = "Keylogger & Detector";
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnDetect);
            this.ResumeLayout(false);
        }
    }
}