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
            this.userNameTextbox = new CCWin.SkinControl.SkinTextBox();
            this.pwdTextbox = new CCWin.SkinControl.SkinTextBox();
            this.pwdLabel = new CCWin.SkinControl.SkinLabel();
            this.ChoosedbCb = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.ErrorImage = null;
            this.skinPictureBox1.Image = global::InventoryApp.Properties.Resources.loginImg;
            this.skinPictureBox1.InitialImage = null;
            this.skinPictureBox1.Location = new System.Drawing.Point(827, 138);
            this.skinPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(652, 681);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox1.TabIndex = 3;
            this.skinPictureBox1.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.BorderColor = System.Drawing.Color.White;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameLabel.Location = new System.Drawing.Point(131, 494);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(173, 41);
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
            this.userNameTextbox.Location = new System.Drawing.Point(328, 494);
            this.userNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.userNameTextbox.MaxLength = 32767;
            this.userNameTextbox.MinimumSize = new System.Drawing.Size(56, 58);
            this.userNameTextbox.MouseBack = null;
            this.userNameTextbox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextbox.Multiline = true;
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.NormlBack = null;
            this.userNameTextbox.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.userNameTextbox.ReadOnly = false;
            this.userNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextbox.Size = new System.Drawing.Size(413, 58);
            // 
            // 
            // 
            this.userNameTextbox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextbox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextbox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameTextbox.SkinTxt.Location = new System.Drawing.Point(11, 10);
            this.userNameTextbox.SkinTxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userNameTextbox.SkinTxt.Multiline = true;
            this.userNameTextbox.SkinTxt.Name = "BaseText";
            this.userNameTextbox.SkinTxt.Size = new System.Drawing.Size(391, 38);
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
            this.pwdTextbox.Location = new System.Drawing.Point(328, 588);
            this.pwdTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.pwdTextbox.MaxLength = 32767;
            this.pwdTextbox.MinimumSize = new System.Drawing.Size(56, 58);
            this.pwdTextbox.MouseBack = null;
            this.pwdTextbox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.pwdTextbox.Multiline = true;
            this.pwdTextbox.Name = "pwdTextbox";
            this.pwdTextbox.NormlBack = null;
            this.pwdTextbox.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pwdTextbox.ReadOnly = false;
            this.pwdTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdTextbox.Size = new System.Drawing.Size(413, 58);
            // 
            // 
            // 
            this.pwdTextbox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdTextbox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwdTextbox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdTextbox.SkinTxt.Location = new System.Drawing.Point(11, 10);
            this.pwdTextbox.SkinTxt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pwdTextbox.SkinTxt.Multiline = true;
            this.pwdTextbox.SkinTxt.Name = "BaseText";
            this.pwdTextbox.SkinTxt.Size = new System.Drawing.Size(391, 38);
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
            this.pwdLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel.Location = new System.Drawing.Point(131, 588);
            this.pwdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(163, 41);
            this.pwdLabel.TabIndex = 7;
            this.pwdLabel.Text = "Password";
            // 
            // ChoosedbCb
            // 
            this.ChoosedbCb.ArrowColor = System.Drawing.Color.Black;
            this.ChoosedbCb.BaseColor = System.Drawing.Color.White;
            this.ChoosedbCb.BorderColor = System.Drawing.Color.DarkGray;
            this.ChoosedbCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChoosedbCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosedbCb.FormattingEnabled = true;
            this.ChoosedbCb.ItemBorderColor = System.Drawing.SystemColors.ControlLight;
            this.ChoosedbCb.Items.AddRange(new object[] {
            "Inventory Database",
            "Backup Database"});
            this.ChoosedbCb.Location = new System.Drawing.Point(209, 376);
            this.ChoosedbCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChoosedbCb.MouseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChoosedbCb.MouseGradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChoosedbCb.Name = "ChoosedbCb";
            this.ChoosedbCb.Size = new System.Drawing.Size(528, 69);
            this.ChoosedbCb.TabIndex = 1;
            this.ChoosedbCb.Text = "Choose DataBase";
            this.ChoosedbCb.WaterText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 147);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton1.Location = new System.Drawing.Point(415, 708);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(96, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "Login";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1481, 869);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.pwdTextbox);
            this.Controls.Add(this.userNameTextbox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.ChoosedbCb);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private CCWin.SkinControl.SkinTextBox userNameTextbox;
        private CCWin.SkinControl.SkinTextBox pwdTextbox;
        private CCWin.SkinControl.SkinLabel pwdLabel;
        private CCWin.SkinControl.SkinComboBox ChoosedbCb;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

