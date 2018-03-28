﻿namespace InventoryApp
{
    partial class Welcome
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
            this.WelcomeLable = new CCWin.SkinControl.SkinLabel();
            this.ChoosedbCb = new CCWin.SkinControl.SkinComboBox();
            this.LoginBtn = new CCWin.SkinControl.SkinButton();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.userNameLabel = new CCWin.SkinControl.SkinLabel();
            this.userNameTextbox = new CCWin.SkinControl.SkinTextBox();
            this.pwdTextbox = new CCWin.SkinControl.SkinTextBox();
            this.pwdLabel = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.AutoSize = true;
            this.WelcomeLable.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLable.BorderColor = System.Drawing.Color.White;
            this.WelcomeLable.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(74, 3);
            this.WelcomeLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(249, 85);
            this.WelcomeLable.TabIndex = 0;
            this.WelcomeLable.Text = "Welcome";
            // 
            // ChoosedbCb
            // 
            this.ChoosedbCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChoosedbCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosedbCb.FormattingEnabled = true;
            this.ChoosedbCb.Items.AddRange(new object[] {
            "Inventory Database",
            "Backup Database"});
            this.ChoosedbCb.Location = new System.Drawing.Point(127, 90);
            this.ChoosedbCb.Margin = new System.Windows.Forms.Padding(2);
            this.ChoosedbCb.Name = "ChoosedbCb";
            this.ChoosedbCb.Size = new System.Drawing.Size(207, 27);
            this.ChoosedbCb.TabIndex = 1;
            this.ChoosedbCb.Text = "Choose DataBase";
            this.ChoosedbCb.WaterText = "";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BaseColor = System.Drawing.Color.White;
            this.LoginBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.LoginBtn.DownBack = null;
            this.LoginBtn.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(149, 226);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoginBtn.MouseBack = null;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NormlBack = null;
            this.LoginBtn.Size = new System.Drawing.Size(109, 33);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.loginBtnClick);
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.ErrorImage = null;
            this.skinPictureBox1.Image = global::InventoryApp.Properties.Resources.loginImg;
            this.skinPictureBox1.InitialImage = null;
            this.skinPictureBox1.Location = new System.Drawing.Point(379, 3);
            this.skinPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(231, 256);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox1.TabIndex = 3;
            this.skinPictureBox1.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.BorderColor = System.Drawing.Color.White;
            this.userNameLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameLabel.Location = new System.Drawing.Point(28, 133);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(87, 21);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Username";
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.userNameTextbox.DownBack = null;
            this.userNameTextbox.Icon = null;
            this.userNameTextbox.IconIsButton = false;
            this.userNameTextbox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextbox.IsPasswordChat = '\0';
            this.userNameTextbox.IsSystemPasswordChar = false;
            this.userNameTextbox.Lines = new string[0];
            this.userNameTextbox.Location = new System.Drawing.Point(127, 133);
            this.userNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.userNameTextbox.MaxLength = 32767;
            this.userNameTextbox.MinimumSize = new System.Drawing.Size(28, 28);
            this.userNameTextbox.MouseBack = null;
            this.userNameTextbox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextbox.Multiline = false;
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.NormlBack = null;
            this.userNameTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.userNameTextbox.ReadOnly = false;
            this.userNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextbox.Size = new System.Drawing.Size(207, 28);
            // 
            // 
            // 
            this.userNameTextbox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextbox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextbox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameTextbox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.userNameTextbox.SkinTxt.Name = "BaseText";
            this.userNameTextbox.SkinTxt.Size = new System.Drawing.Size(197, 22);
            this.userNameTextbox.SkinTxt.TabIndex = 0;
            this.userNameTextbox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextbox.SkinTxt.WaterText = "";
            this.userNameTextbox.TabIndex = 5;
            this.userNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTextbox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextbox.WaterText = "";
            this.userNameTextbox.WordWrap = true;
            // 
            // pwdTextbox
            // 
            this.pwdTextbox.BackColor = System.Drawing.Color.Transparent;
            this.pwdTextbox.DownBack = null;
            this.pwdTextbox.Icon = null;
            this.pwdTextbox.IconIsButton = false;
            this.pwdTextbox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.pwdTextbox.IsPasswordChat = '\0';
            this.pwdTextbox.IsSystemPasswordChar = false;
            this.pwdTextbox.Lines = new string[0];
            this.pwdTextbox.Location = new System.Drawing.Point(127, 178);
            this.pwdTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.pwdTextbox.MaxLength = 32767;
            this.pwdTextbox.MinimumSize = new System.Drawing.Size(28, 28);
            this.pwdTextbox.MouseBack = null;
            this.pwdTextbox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.pwdTextbox.Multiline = false;
            this.pwdTextbox.Name = "pwdTextbox";
            this.pwdTextbox.NormlBack = null;
            this.pwdTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.pwdTextbox.ReadOnly = false;
            this.pwdTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdTextbox.Size = new System.Drawing.Size(207, 28);
            // 
            // 
            // 
            this.pwdTextbox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdTextbox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwdTextbox.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdTextbox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.pwdTextbox.SkinTxt.Name = "BaseText";
            this.pwdTextbox.SkinTxt.Size = new System.Drawing.Size(197, 22);
            this.pwdTextbox.SkinTxt.TabIndex = 0;
            this.pwdTextbox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pwdTextbox.SkinTxt.WaterText = "";
            this.pwdTextbox.TabIndex = 6;
            this.pwdTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pwdTextbox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pwdTextbox.WaterText = "";
            this.pwdTextbox.WordWrap = true;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel.BorderColor = System.Drawing.Color.White;
            this.pwdLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel.Location = new System.Drawing.Point(28, 178);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(82, 21);
            this.pwdLabel.TabIndex = 7;
            this.pwdLabel.Text = "Password";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 270);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.pwdTextbox);
            this.Controls.Add(this.userNameTextbox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ChoosedbCb);
            this.Controls.Add(this.WelcomeLable);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Welcome";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel WelcomeLable;
        private CCWin.SkinControl.SkinComboBox ChoosedbCb;
        private CCWin.SkinControl.SkinButton LoginBtn;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinLabel userNameLabel;
        private CCWin.SkinControl.SkinTextBox userNameTextbox;
        private CCWin.SkinControl.SkinTextBox pwdTextbox;
        private CCWin.SkinControl.SkinLabel pwdLabel;
    }
}
