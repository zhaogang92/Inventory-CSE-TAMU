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
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.Animation animation2 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.skinAnimator1 = new CCWin.SkinControl.SkinAnimator(this.components);
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.userNameTextbox = new CCWin.SkinControl.SkinTextBox();
            this.btnId = new CCWin.SkinControl.SkinButton();
            this.pwdTextbox = new CCWin.SkinControl.SkinTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.LoginBtn = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.userNameTextbox.SuspendLayout();
            this.pwdTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinAnimator1
            // 
            this.skinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.Custom;
            this.skinAnimator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.skinAnimator1.DefaultAnimation = animation2;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.BackgroundImage = global::InventoryApp.Properties.Resources.user_avatar;
            this.skinPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinAnimator1.SetDecoration(this.skinPictureBox1, CCWin.SkinControl.DecorationType.None);
            this.skinPictureBox1.Location = new System.Drawing.Point(156, 118);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.skinPictureBox1.TabIndex = 12;
            this.skinPictureBox1.TabStop = false;
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.userNameTextbox.Controls.Add(this.btnId);
            this.skinAnimator1.SetDecoration(this.userNameTextbox, CCWin.SkinControl.DecorationType.None);
            this.userNameTextbox.DownBack = null;
            this.userNameTextbox.Icon = null;
            this.userNameTextbox.IconIsButton = false;
            this.userNameTextbox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextbox.IsPasswordChat = '\0';
            this.userNameTextbox.IsSystemPasswordChar = false;
            this.userNameTextbox.Lines = new string[0];
            this.userNameTextbox.Location = new System.Drawing.Point(13, 500);
            this.userNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.userNameTextbox.MaxLength = 32767;
            this.userNameTextbox.MinimumSize = new System.Drawing.Size(28, 28);
            this.userNameTextbox.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("userNameTextbox.MouseBack")));
            this.userNameTextbox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.userNameTextbox.Multiline = true;
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("userNameTextbox.NormlBack")));
            this.userNameTextbox.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.userNameTextbox.ReadOnly = false;
            this.userNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextbox.Size = new System.Drawing.Size(450, 50);
            // 
            // 
            // 
            this.userNameTextbox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextbox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTextbox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.userNameTextbox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.userNameTextbox.SkinTxt.Multiline = true;
            this.userNameTextbox.SkinTxt.Name = "BaseText";
            this.userNameTextbox.SkinTxt.Size = new System.Drawing.Size(417, 40);
            this.userNameTextbox.SkinTxt.TabIndex = 0;
            this.userNameTextbox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextbox.SkinTxt.WaterText = "User Name";
            this.userNameTextbox.TabIndex = 40;
            this.userNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userNameTextbox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.userNameTextbox.WaterText = "User Name";
            this.userNameTextbox.WordWrap = true;
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.White;
            this.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinAnimator1.SetDecoration(this.btnId, CCWin.SkinControl.DecorationType.None);
            this.btnId.DownBack = ((System.Drawing.Image)(resources.GetObject("btnId.DownBack")));
            this.btnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnId.IsEnabledDraw = false;
            this.btnId.Location = new System.Drawing.Point(170, 3);
            this.btnId.Margin = new System.Windows.Forms.Padding(0);
            this.btnId.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnId.MouseBack")));
            this.btnId.Name = "btnId";
            this.btnId.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnId.NormlBack")));
            this.btnId.Size = new System.Drawing.Size(22, 24);
            this.btnId.TabIndex = 36;
            this.btnId.UseVisualStyleBackColor = false;
            // 
            // pwdTextbox
            // 
            this.pwdTextbox.BackColor = System.Drawing.Color.Transparent;
            this.pwdTextbox.Controls.Add(this.skinButton1);
            this.skinAnimator1.SetDecoration(this.pwdTextbox, CCWin.SkinControl.DecorationType.None);
            this.pwdTextbox.DownBack = null;
            this.pwdTextbox.Icon = null;
            this.pwdTextbox.IconIsButton = false;
            this.pwdTextbox.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.pwdTextbox.IsPasswordChat = '\0';
            this.pwdTextbox.IsSystemPasswordChar = false;
            this.pwdTextbox.Lines = new string[0];
            this.pwdTextbox.Location = new System.Drawing.Point(13, 571);
            this.pwdTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.pwdTextbox.MaxLength = 32767;
            this.pwdTextbox.MinimumSize = new System.Drawing.Size(28, 28);
            this.pwdTextbox.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("pwdTextbox.MouseBack")));
            this.pwdTextbox.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.pwdTextbox.Multiline = true;
            this.pwdTextbox.Name = "pwdTextbox";
            this.pwdTextbox.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("pwdTextbox.NormlBack")));
            this.pwdTextbox.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.pwdTextbox.ReadOnly = false;
            this.pwdTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdTextbox.Size = new System.Drawing.Size(450, 50);
            // 
            // 
            // 
            this.pwdTextbox.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwdTextbox.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwdTextbox.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.pwdTextbox.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.pwdTextbox.SkinTxt.Multiline = true;
            this.pwdTextbox.SkinTxt.Name = "BaseText";
            this.pwdTextbox.SkinTxt.Size = new System.Drawing.Size(417, 40);
            this.pwdTextbox.SkinTxt.TabIndex = 0;
            this.pwdTextbox.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pwdTextbox.SkinTxt.WaterText = "Password";
            this.pwdTextbox.TabIndex = 41;
            this.pwdTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pwdTextbox.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pwdTextbox.WaterText = "Password";
            this.pwdTextbox.WordWrap = true;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.White;
            this.skinButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinAnimator1.SetDecoration(this.skinButton1, CCWin.SkinControl.DecorationType.None);
            this.skinButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.DownBack")));
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.IsEnabledDraw = false;
            this.skinButton1.Location = new System.Drawing.Point(170, 3);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(0);
            this.skinButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.MouseBack")));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.NormlBack")));
            this.skinButton1.Size = new System.Drawing.Size(22, 24);
            this.skinButton1.TabIndex = 36;
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBtn.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.LoginBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.LoginBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.LoginBtn, CCWin.SkinControl.DecorationType.None);
            this.LoginBtn.DownBack = ((System.Drawing.Image)(resources.GetObject("LoginBtn.DownBack")));
            this.LoginBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(156, 662);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LoginBtn.MouseBack = ((System.Drawing.Image)(resources.GetObject("LoginBtn.MouseBack")));
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NormlBack = ((System.Drawing.Image)(resources.GetObject("LoginBtn.NormlBack")));
            this.LoginBtn.Size = new System.Drawing.Size(147, 56);
            this.LoginBtn.TabIndex = 42;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::InventoryApp.Properties.Resources.Back;
            this.BorderColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(470, 830);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = global::InventoryApp.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::InventoryApp.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::InventoryApp.Properties.Resources.CloseNormlBack;
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pwdTextbox);
            this.Controls.Add(this.userNameTextbox);
            this.Controls.Add(this.skinPictureBox1);
            this.skinAnimator1.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.InnerBorderColor = System.Drawing.Color.Transparent;
            this.MaxDownBack = global::InventoryApp.Properties.Resources.MaxDownBack;
            this.MaxMouseBack = global::InventoryApp.Properties.Resources.MaxMouseBack;
            this.MaxNormlBack = global::InventoryApp.Properties.Resources.MaxNormlBack;
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = global::InventoryApp.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::InventoryApp.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::InventoryApp.Properties.Resources.MiniNormlBack;
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "Welcome";
            this.Radius = 1;
            this.RestoreDownBack = global::InventoryApp.Properties.Resources.RestoreDownBack;
            this.RestoreMouseBack = global::InventoryApp.Properties.Resources.RestoreMouseBack;
            this.RestoreNormlBack = global::InventoryApp.Properties.Resources.RestoreNormlBack;
            this.Shadow = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.userNameTextbox.ResumeLayout(false);
            this.userNameTextbox.PerformLayout();
            this.pwdTextbox.ResumeLayout(false);
            this.pwdTextbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinAnimator skinAnimator1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinTextBox userNameTextbox;
        private CCWin.SkinControl.SkinButton btnId;
        private CCWin.SkinControl.SkinTextBox pwdTextbox;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton LoginBtn;
    }
}

