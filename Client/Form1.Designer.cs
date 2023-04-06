namespace Client
{
    partial class ClientForm
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
            txtServerIP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPortNr = new TextBox();
            btnConnect = new Button();
            txtDataToServer = new TextBox();
            label3 = new Label();
            btnSend = new Button();
            txtTest = new TextBox();
            SuspendLayout();
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(12, 33);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(100, 23);
            txtServerIP.TabIndex = 0;
            txtServerIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "Ziel Server IP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 15);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // txtPortNr
            // 
            txtPortNr.Location = new Point(132, 33);
            txtPortNr.Name = "txtPortNr";
            txtPortNr.Size = new Size(100, 23);
            txtPortNr.TabIndex = 2;
            txtPortNr.Text = "50000";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(249, 33);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtDataToServer
            // 
            txtDataToServer.Location = new Point(12, 104);
            txtDataToServer.Multiline = true;
            txtDataToServer.Name = "txtDataToServer";
            txtDataToServer.Size = new Size(417, 149);
            txtDataToServer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Data zum Server";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 271);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtTest
            // 
            txtTest.Location = new Point(12, 374);
            txtTest.Name = "txtTest";
            txtTest.Size = new Size(100, 23);
            txtTest.TabIndex = 8;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTest);
            Controls.Add(btnSend);
            Controls.Add(label3);
            Controls.Add(txtDataToServer);
            Controls.Add(btnConnect);
            Controls.Add(label2);
            Controls.Add(txtPortNr);
            Controls.Add(label1);
            Controls.Add(txtServerIP);
            Name = "ClientForm";
            Text = "Client";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServerIP;
        private Label label1;
        private Label label2;
        private TextBox txtPortNr;
        private Button btnConnect;
        private TextBox txtDataToServer;
        private Label label3;
        private Button btnSend;
        private TextBox txtTest;
    }
}