namespace Download_Master_Torrent_Association_Tool
{
    partial class MainForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxMagnet = new System.Windows.Forms.CheckBox();
            this.checkBoxTorrent = new System.Windows.Forms.CheckBox();
            this.checkBoxNZB = new System.Windows.Forms.CheckBox();
            this.checkBoxEd2k = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(12, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(12, 35);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(76, 6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(76, 32);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(76, 58);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 4;
            this.textBoxIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIP_KeyPress);
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(12, 61);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(61, 13);
            this.labelIPAddress.TabIndex = 5;
            this.labelIPAddress.Text = "IP Address:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(76, 84);
            this.textBoxPort.MaxLength = 5;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 6;
            this.textBoxPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPort_KeyPress);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 87);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 13);
            this.labelPort.TabIndex = 7;
            this.labelPort.Text = "Port:";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(164, 110);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 8;
            this.buttonApply.Text = "Save";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(245, 110);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Close";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxMagnet
            // 
            this.checkBoxMagnet.AutoSize = true;
            this.checkBoxMagnet.Location = new System.Drawing.Point(182, 8);
            this.checkBoxMagnet.Name = "checkBoxMagnet";
            this.checkBoxMagnet.Size = new System.Drawing.Size(139, 17);
            this.checkBoxMagnet.TabIndex = 10;
            this.checkBoxMagnet.Text = "Associate Magnet Links";
            this.checkBoxMagnet.UseVisualStyleBackColor = true;
            // 
            // checkBoxTorrent
            // 
            this.checkBoxTorrent.AutoSize = true;
            this.checkBoxTorrent.Location = new System.Drawing.Point(182, 35);
            this.checkBoxTorrent.Name = "checkBoxTorrent";
            this.checkBoxTorrent.Size = new System.Drawing.Size(133, 17);
            this.checkBoxTorrent.TabIndex = 11;
            this.checkBoxTorrent.Text = "Associate Torrent Files";
            this.checkBoxTorrent.UseVisualStyleBackColor = true;
            // 
            // checkBoxNZB
            // 
            this.checkBoxNZB.AutoSize = true;
            this.checkBoxNZB.Location = new System.Drawing.Point(182, 61);
            this.checkBoxNZB.Name = "checkBoxNZB";
            this.checkBoxNZB.Size = new System.Drawing.Size(121, 17);
            this.checkBoxNZB.TabIndex = 12;
            this.checkBoxNZB.Text = "Associate NZB Files";
            this.checkBoxNZB.UseVisualStyleBackColor = true;
            // 
            // checkBoxEd2k
            // 
            this.checkBoxEd2k.AutoSize = true;
            this.checkBoxEd2k.Location = new System.Drawing.Point(182, 87);
            this.checkBoxEd2k.Name = "checkBoxEd2k";
            this.checkBoxEd2k.Size = new System.Drawing.Size(123, 17);
            this.checkBoxEd2k.TabIndex = 13;
            this.checkBoxEd2k.Text = "Associate ed2k Files";
            this.checkBoxEd2k.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 138);
            this.Controls.Add(this.checkBoxEd2k);
            this.Controls.Add(this.checkBoxNZB);
            this.Controls.Add(this.checkBoxTorrent);
            this.Controls.Add(this.checkBoxMagnet);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelIPAddress);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Unofficial ASUS Download Master File Association Tool";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MainForm_HelpButtonClicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxMagnet;
        private System.Windows.Forms.CheckBox checkBoxTorrent;
        private System.Windows.Forms.CheckBox checkBoxNZB;
        private System.Windows.Forms.CheckBox checkBoxEd2k;

    }
}

