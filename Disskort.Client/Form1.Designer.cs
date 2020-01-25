namespace Disskort
{
    partial class DisskortWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.gbAdminConsole = new System.Windows.Forms.GroupBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.lbServerStatus = new System.Windows.Forms.ListBox();
            this.gbAdminLogin = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbAdminKey = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblAdminKey = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.timerChatUpdate = new System.Windows.Forms.Timer(this.components);
            this.gbChat.SuspendLayout();
            this.gbAdminConsole.SuspendLayout();
            this.gbAdminLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.btnSend);
            this.gbChat.Controls.Add(this.tbMessage);
            this.gbChat.Controls.Add(this.lbChat);
            this.gbChat.Enabled = false;
            this.gbChat.Location = new System.Drawing.Point(12, 12);
            this.gbChat.Name = "gbChat";
            this.gbChat.Size = new System.Drawing.Size(423, 425);
            this.gbChat.TabIndex = 5;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Chat";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(350, 400);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(67, 20);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send ->";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(7, 400);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(340, 20);
            this.tbMessage.TabIndex = 1;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Items.AddRange(new object[] {
            "Beginn dieses Chatverlaufs"});
            this.lbChat.Location = new System.Drawing.Point(7, 13);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(410, 381);
            this.lbChat.TabIndex = 0;
            // 
            // gbAdminConsole
            // 
            this.gbAdminConsole.Controls.Add(this.btnSendCommand);
            this.gbAdminConsole.Controls.Add(this.tbCommand);
            this.gbAdminConsole.Controls.Add(this.lbServerStatus);
            this.gbAdminConsole.Enabled = false;
            this.gbAdminConsole.Location = new System.Drawing.Point(445, 125);
            this.gbAdminConsole.Name = "gbAdminConsole";
            this.gbAdminConsole.Size = new System.Drawing.Size(327, 312);
            this.gbAdminConsole.TabIndex = 6;
            this.gbAdminConsole.TabStop = false;
            this.gbAdminConsole.Text = "Administrator Console";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(254, 286);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(67, 20);
            this.btnSendCommand.TabIndex = 3;
            this.btnSendCommand.Text = "Send ->";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(7, 286);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(241, 20);
            this.tbCommand.TabIndex = 1;
            this.tbCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommand_KeyDown);
            // 
            // lbServerStatus
            // 
            this.lbServerStatus.FormattingEnabled = true;
            this.lbServerStatus.Items.AddRange(new object[] {
            "Verify as admin!"});
            this.lbServerStatus.Location = new System.Drawing.Point(7, 16);
            this.lbServerStatus.Name = "lbServerStatus";
            this.lbServerStatus.Size = new System.Drawing.Size(314, 264);
            this.lbServerStatus.TabIndex = 0;
            // 
            // gbAdminLogin
            // 
            this.gbAdminLogin.Controls.Add(this.btnConnect);
            this.gbAdminLogin.Controls.Add(this.tbAdminKey);
            this.gbAdminLogin.Controls.Add(this.tbName);
            this.gbAdminLogin.Controls.Add(this.lblAdminKey);
            this.gbAdminLogin.Controls.Add(this.lblName);
            this.gbAdminLogin.Location = new System.Drawing.Point(445, 12);
            this.gbAdminLogin.Name = "gbAdminLogin";
            this.gbAdminLogin.Size = new System.Drawing.Size(327, 107);
            this.gbAdminLogin.TabIndex = 7;
            this.gbAdminLogin.TabStop = false;
            this.gbAdminLogin.Text = "Login";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(10, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(311, 38);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbAdminKey
            // 
            this.tbAdminKey.Location = new System.Drawing.Point(122, 36);
            this.tbAdminKey.Name = "tbAdminKey";
            this.tbAdminKey.Size = new System.Drawing.Size(199, 20);
            this.tbAdminKey.TabIndex = 3;
            this.tbAdminKey.UseSystemPasswordChar = true;
            this.tbAdminKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAdminKey_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(122, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(199, 20);
            this.tbName.TabIndex = 2;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lblAdminKey
            // 
            this.lblAdminKey.AutoSize = true;
            this.lblAdminKey.Location = new System.Drawing.Point(7, 39);
            this.lblAdminKey.Name = "lblAdminKey";
            this.lblAdminKey.Size = new System.Drawing.Size(108, 13);
            this.lblAdminKey.TabIndex = 1;
            this.lblAdminKey.Text = "(Optional) Admin Key:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // timerChatUpdate
            // 
            this.timerChatUpdate.Interval = 3000;
            this.timerChatUpdate.Tick += new System.EventHandler(this.timerChatUpdate_Tick);
            // 
            // DisskortWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 445);
            this.Controls.Add(this.gbAdminLogin);
            this.Controls.Add(this.gbAdminConsole);
            this.Controls.Add(this.gbChat);
            this.Name = "DisskortWindow";
            this.Text = "Disskort";
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            this.gbAdminConsole.ResumeLayout(false);
            this.gbAdminConsole.PerformLayout();
            this.gbAdminLogin.ResumeLayout(false);
            this.gbAdminLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.GroupBox gbAdminConsole;
        private System.Windows.Forms.GroupBox gbAdminLogin;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbAdminKey;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblAdminKey;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbServerStatus;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Timer timerChatUpdate;
    }
}

