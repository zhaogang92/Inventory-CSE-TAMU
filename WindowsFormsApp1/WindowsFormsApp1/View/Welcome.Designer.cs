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
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.userNameLabel = new CCWin.SkinControl.SkinLabel();
            this.pwdLabel = new CCWin.SkinControl.SkinLabel();
            this.pwdTextbox = new System.Windows.Forms.TextBox();
            this.userNameTextbox = new System.Windows.Forms.TextBox();
            this.skinAnimator1 = new CCWin.SkinControl.SkinAnimator(this.components);
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.LoginBtn = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.BorderColor = System.Drawing.Color.White;
            this.skinAnimator1.SetDecoration(this.userNameLabel, CCWin.SkinControl.DecorationType.None);
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameLabel.Location = new System.Drawing.Point(7, 484);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(130, 31);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Username";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdLabel.BorderColor = System.Drawing.Color.White;
            this.skinAnimator1.SetDecoration(this.pwdLabel, CCWin.SkinControl.DecorationType.None);
            this.pwdLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pwdLabel.Location = new System.Drawing.Point(9, 561);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(122, 31);
            this.pwdLabel.TabIndex = 7;
            this.pwdLabel.Text = "Password";
            // 
            // pwdTextbox
            // 
            this.skinAnimator1.SetDecoration(this.pwdTextbox, CCWin.SkinControl.DecorationType.None);
            this.pwdTextbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTextbox.Location = new System.Drawing.Point(138, 557);
            this.pwdTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwdTextbox.Name = "pwdTextbox";
            this.pwdTextbox.Size = new System.Drawing.Size(324, 41);
            this.pwdTextbox.TabIndex = 10;
            // 
            // userNameTextbox
            // 
            this.skinAnimator1.SetDecoration(this.userNameTextbox, CCWin.SkinControl.DecorationType.None);
            this.userNameTextbox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextbox.Location = new System.Drawing.Point(138, 480);
            this.userNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(324, 41);
            this.userNameTextbox.TabIndex = 11;
            // 
            // skinAnimator1
            // 
            this.skinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.Custom;
            this.skinAnimator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.skinAnimator1.DefaultAnimation = animation1;
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
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.LoginBtn, CCWin.SkinControl.DecorationType.None);
            this.LoginBtn.DownBack = null;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(169, 708);
            this.LoginBtn.MouseBack = null;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NormlBack = null;
            this.LoginBtn.Size = new System.Drawing.Size(97, 44);
            this.LoginBtn.TabIndex = 13;
            this.LoginBtn.Text = "LOGIN";
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
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.userNameTextbox);
            this.Controls.Add(this.pwdTextbox);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.userNameLabel);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel userNameLabel;
        //private CCWin.SkinControl.SkinTextBox userNameTextbox;
        //private CCWin.SkinControl.SkinTextBox pwdTextbox;
        //private System.Windows.Forms.TextBox userNameTextbox;
        //private System.Windows.Forms.TextBox pwdTextbox;
        private CCWin.SkinControl.SkinLabel pwdLabel;
        private System.Windows.Forms.TextBox pwdTextbox;
        private System.Windows.Forms.TextBox userNameTextbox;
        private CCWin.SkinControl.SkinAnimator skinAnimator1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private CCWin.SkinControl.SkinButton LoginBtn;
    }
}

