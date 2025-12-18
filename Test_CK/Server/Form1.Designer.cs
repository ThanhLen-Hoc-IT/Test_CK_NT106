namespace Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIPAddress = new TextBox();
            txtPort = new TextBox();
            rtbLog = new RichTextBox();
            btnListen = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(170, 29);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(278, 27);
            txtIPAddress.TabIndex = 0;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(170, 81);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(278, 27);
            txtPort.TabIndex = 1;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(86, 141);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(557, 287);
            rtbLog.TabIndex = 2;
            rtbLog.Text = "";
            // 
            // btnListen
            // 
            btnListen.Location = new Point(549, 27);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(94, 29);
            btnListen.TabIndex = 3;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 36);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 4;
            label1.Text = "IP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 88);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnListen);
            Controls.Add(rtbLog);
            Controls.Add(txtPort);
            Controls.Add(txtIPAddress);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIPAddress;
        private TextBox txtPort;
        private RichTextBox rtbLog;
        private Button btnListen;
        private Label label1;
        private Label label2;
    }
}
