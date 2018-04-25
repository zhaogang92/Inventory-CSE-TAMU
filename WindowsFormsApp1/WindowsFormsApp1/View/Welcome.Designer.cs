namespace InventoryApp
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
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.userNameLabel = new CCWin.SkinControl.SkinLabel();
            this.pwdLabel = new CCWin.SkinControl.SkinLabel();
            //this.ChoosedbCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.pwdTextbox = new System.Windows.Forms.TextBox();
            this.userNameTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.ErrorImage = null;
            this.skinPictureBox1.Image = global::InventoryApp.Properties.Resources.loginImg;
            this.skinPictureBox1.InitialImage = null;
            this.skinPictureBox1.Location = new System.Drawing.Point(414, 66);
            this.skinPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(326, 327);
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
            this.userNameLabel.Location = new System.Drawing.Point(66, 237);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(87, 21);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Username";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel.BorderColor = System.Drawing.Color.White;
            this.pwdLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel.Location = new System.Drawing.Point(66, 282);
            this.pwdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(82, 21);
            this.pwdLabel.TabIndex = 7;
            this.pwdLabel.Text = "Password";
            // 
            // ChoosedbCb
            // 
            //this.ChoosedbCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            //this.ChoosedbCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.ChoosedbCb.FormattingEnabled = true;
            //this.ChoosedbCb.Items.AddRange(new object[] {
            //"Inventory Database",
            //"Backup Database"});
            //this.ChoosedbCb.Location = new System.Drawing.Point(104, 180);
            //this.ChoosedbCb.Margin = new System.Windows.Forms.Padding(2);
            //this.ChoosedbCb.Name = "ChoosedbCb";
            //this.ChoosedbCb.Size = new System.Drawing.Size(266, 32);
            //this.ChoosedbCb.TabIndex = 1;
            //this.ChoosedbCb.Text = "Choose DataBase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 90);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = true;
            this.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBtn.Depth = 0;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(208, 340);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Primary = false;
            this.loginBtn.Size = new System.Drawing.Size(52, 36);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtnClick);
            // 
            // pwdTextbox
            // 
            this.pwdTextbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTextbox.Location = new System.Drawing.Point(175, 282);
            this.pwdTextbox.Name = "pwdTextbox";
            this.pwdTextbox.Size = new System.Drawing.Size(198, 30);
            this.pwdTextbox.TabIndex = 10;
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextbox.Location = new System.Drawing.Point(175, 236);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(198, 30);
            this.userNameTextbox.TabIndex = 11;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(740, 417);
            this.Controls.Add(this.userNameTextbox);
            this.Controls.Add(this.pwdTextbox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.skinPictureBox1);
            //this.Controls.Add(this.ChoosedbCb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Welcome";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinLabel userNameLabel;
        //private CCWin.SkinControl.SkinTextBox userNameTextbox;
        //private CCWin.SkinControl.SkinTextBox pwdTextbox;
        //private System.Windows.Forms.TextBox userNameTextbox;
        //private System.Windows.Forms.TextBox pwdTextbox;
        private CCWin.SkinControl.SkinLabel pwdLabel;
        //private CCWin.SkinControl.SkinComboBox ChoosedbCb;
        //private System.Windows.Forms.ComboBox ChoosedbCb;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton loginBtn;
        private System.Windows.Forms.TextBox pwdTextbox;
        private System.Windows.Forms.TextBox userNameTextbox;
    }
}

