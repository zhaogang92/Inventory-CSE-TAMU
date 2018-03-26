namespace WindowsFormsApp1
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
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLable
            // 
            this.WelcomeLable.AutoSize = true;
            this.WelcomeLable.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLable.BorderColor = System.Drawing.Color.White;
            this.WelcomeLable.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLable.Location = new System.Drawing.Point(51, 68);
            this.WelcomeLable.Name = "WelcomeLable";
            this.WelcomeLable.Size = new System.Drawing.Size(370, 127);
            this.WelcomeLable.TabIndex = 0;
            this.WelcomeLable.Text = "Welcome";
            this.WelcomeLable.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // ChoosedbCb
            // 
            this.ChoosedbCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ChoosedbCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosedbCb.FormattingEnabled = true;
            this.ChoosedbCb.Location = new System.Drawing.Point(73, 230);
            this.ChoosedbCb.Name = "ChoosedbCb";
            this.ChoosedbCb.Size = new System.Drawing.Size(308, 36);
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
            this.LoginBtn.Location = new System.Drawing.Point(134, 320);
            this.LoginBtn.MouseBack = null;
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.NormlBack = null;
            this.LoginBtn.Size = new System.Drawing.Size(164, 55);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Business_mand_and_woman___laughing;
            this.skinPictureBox1.InitialImage = null;
            this.skinPictureBox1.Location = new System.Drawing.Point(442, 12);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(346, 426);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox1.TabIndex = 3;
            this.skinPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skinPictureBox1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ChoosedbCb);
            this.Controls.Add(this.WelcomeLable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel WelcomeLable;
        private CCWin.SkinControl.SkinComboBox ChoosedbCb;
        private CCWin.SkinControl.SkinButton LoginBtn;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
    }
}

