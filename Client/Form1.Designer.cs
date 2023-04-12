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
            txtDataFromServer = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(12, 37);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(100, 25);
            txtServerIP.TabIndex = 0;
            txtServerIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(83, 17);
            label1.TabIndex = 1;
            label1.Text = "Ziel Server IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 17);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // txtPortNr
            // 
            txtPortNr.Location = new Point(132, 37);
            txtPortNr.Name = "txtPortNr";
            txtPortNr.Size = new Size(100, 25);
            txtPortNr.TabIndex = 2;
            txtPortNr.Text = "50000";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(249, 37);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 26);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtDataToServer
            // 
            txtDataToServer.Location = new Point(383, 132);
            txtDataToServer.Multiline = true;
            txtDataToServer.Name = "txtDataToServer";
            txtDataToServer.Size = new Size(300, 154);
            txtDataToServer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 112);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 6;
            label3.Text = "Data zum Server";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(383, 292);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 26);
            btnSend.TabIndex = 7;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtDataFromServer
            // 
            txtDataFromServer.Location = new Point(12, 132);
            txtDataFromServer.Multiline = true;
            txtDataFromServer.Name = "txtDataFromServer";
            txtDataFromServer.Size = new Size(297, 154);
            txtDataFromServer.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(105, 17);
            label4.TabIndex = 9;
            label4.Text = "Data vom Server";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(12, 363);
            label5.Name = "label5";
            label5.Size = new Size(200, 86);
            label5.TabIndex = 13;
            label5.Text = "Client";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDataFromServer);
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
        private TextBox txtDataFromServer;
        private Label label4;
        private Label label5;
    }
}