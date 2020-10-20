namespace SimpleChat_Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pAvatar = new System.Windows.Forms.PictureBox();
            this.msgBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userList = new System.Windows.Forms.ListBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.openFile = new System.Windows.Forms.PictureBox();
            this.sendBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvatar)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 19);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(808, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.profilePanel.Controls.Add(this.settings);
            this.profilePanel.Controls.Add(this.label1);
            this.profilePanel.Controls.Add(this.pAvatar);
            this.profilePanel.Location = new System.Drawing.Point(0, 575);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(259, 64);
            this.profilePanel.TabIndex = 7;
            // 
            // settings
            // 
            this.settings.Image = global::Chat.Properties.Resources.icons8_Settings_48px;
            this.settings.Location = new System.Drawing.Point(216, 13);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(37, 39);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 2;
            this.settings.TabStop = false;
            this.settings.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name";
            // 
            // pAvatar
            // 
            this.pAvatar.Image = global::Chat.Properties.Resources.icons8_User_50px;
            this.pAvatar.Location = new System.Drawing.Point(12, 7);
            this.pAvatar.Name = "pAvatar";
            this.pAvatar.Size = new System.Drawing.Size(54, 50);
            this.pAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pAvatar.TabIndex = 0;
            this.pAvatar.TabStop = false;
            this.pAvatar.DoubleClick += new System.EventHandler(this.pAvatar_DoubleClick);
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msgBox.BorderColorFocused = System.Drawing.Color.White;
            this.msgBox.BorderColorIdle = System.Drawing.Color.DimGray;
            this.msgBox.BorderColorMouseHover = System.Drawing.Color.White;
            this.msgBox.BorderThickness = 1;
            this.msgBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msgBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.msgBox.ForeColor = System.Drawing.Color.White;
            this.msgBox.isPassword = false;
            this.msgBox.Location = new System.Drawing.Point(301, 586);
            this.msgBox.Margin = new System.Windows.Forms.Padding(4);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(513, 44);
            this.msgBox.TabIndex = 8;
            this.msgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel5.Controls.Add(this.userList);
            this.panel5.ForeColor = System.Drawing.SystemColors.Control;
            this.panel5.Location = new System.Drawing.Point(0, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 557);
            this.panel5.TabIndex = 10;
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.userList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userList.ForeColor = System.Drawing.Color.White;
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 22;
            this.userList.Location = new System.Drawing.Point(3, 6);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(250, 550);
            this.userList.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // userMenu
            // 
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // chatBox
            // 
            this.chatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Enabled = false;
            this.chatBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chatBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.chatBox.Location = new System.Drawing.Point(259, 25);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chatBox.Size = new System.Drawing.Size(601, 554);
            this.chatBox.TabIndex = 8;
            this.chatBox.Text = "";
            // 
            // openFile
            // 
            this.openFile.Image = global::Chat.Properties.Resources.icons8_Add_64px_6;
            this.openFile.Location = new System.Drawing.Point(261, 588);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(39, 41);
            this.openFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.openFile.TabIndex = 9;
            this.openFile.TabStop = false;
            // 
            // sendBtn
            // 
            this.sendBtn.Image = global::Chat.Properties.Resources.icons8_Email_Send_50px;
            this.sendBtn.Location = new System.Drawing.Point(820, 586);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(40, 44);
            this.sendBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sendBtn.TabIndex = 0;
            this.sendBtn.TabStop = false;
            this.sendBtn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(866, 639);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvatar)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel profilePanel;
        private Bunifu.Framework.UI.BunifuMetroTextbox msgBox;
        private System.Windows.Forms.PictureBox sendBtn;
        private System.Windows.Forms.PictureBox openFile;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ContextMenuStrip userMenu;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.PictureBox settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pAvatar;
        private System.Windows.Forms.RichTextBox chatBox;
    }
}

