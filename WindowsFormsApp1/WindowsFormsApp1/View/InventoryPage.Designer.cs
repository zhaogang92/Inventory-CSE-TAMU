namespace InventoryApp
{
    partial class InventoryPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.userAddBtn = new CCWin.SkinControl.SkinButton();
            this.clearCheckedBtn = new CCWin.SkinControl.SkinButton();
            this.userUpdateBtn = new CCWin.SkinControl.SkinButton();
            this.backupBtn = new CCWin.SkinControl.SkinButton();
            this.button1 = new CCWin.SkinControl.SkinButton();
            this.button2 = new CCWin.SkinControl.SkinButton();
            this.addBtn = new CCWin.SkinControl.SkinButton();
            this.editBtn = new CCWin.SkinControl.SkinButton();
            this.deleteBtn = new CCWin.SkinControl.SkinButton();
            this.searchBtn = new CCWin.SkinControl.SkinButton();
            this.lablePage = new System.Windows.Forms.Label();
            this.staffcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomtextBox = new System.Windows.Forms.TextBox();
            this.buildingtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(4, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userAddBtn);
            this.splitContainer1.Panel2.Controls.Add(this.clearCheckedBtn);
            this.splitContainer1.Panel2.Controls.Add(this.userUpdateBtn);
            this.splitContainer1.Panel2.Controls.Add(this.backupBtn);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.addBtn);
            this.splitContainer1.Panel2.Controls.Add(this.editBtn);
            this.splitContainer1.Panel2.Controls.Add(this.deleteBtn);
            this.splitContainer1.Panel2.Controls.Add(this.searchBtn);
            this.splitContainer1.Panel2.Controls.Add(this.lablePage);
            this.splitContainer1.Panel2.Controls.Add(this.staffcomboBox);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.roomtextBox);
            this.splitContainer1.Panel2.Controls.Add(this.buildingtextBox);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1412, 718);
            this.splitContainer1.SplitterDistance = 656;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1412, 656);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.itemsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1404, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(1398, 618);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellClick);
            this.itemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellContentClick);
            this.itemsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.staffDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1404, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Staffs";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(1398, 618);
            this.staffDataGridView.TabIndex = 1;
            this.staffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridView_CellClick);
            // 
            // userAddBtn
            // 
            this.userAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.userAddBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.userAddBtn.DownBack = null;
            this.userAddBtn.Location = new System.Drawing.Point(1070, 19);
            this.userAddBtn.MouseBack = null;
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.NormlBack = null;
            this.userAddBtn.Size = new System.Drawing.Size(75, 23);
            this.userAddBtn.TabIndex = 53;
            this.userAddBtn.Text = "skinButton1";
            this.userAddBtn.UseVisualStyleBackColor = false;
            this.userAddBtn.Click += new System.EventHandler(this.userAddBtn_Click);
            // 
            // clearCheckedBtn
            // 
            this.clearCheckedBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearCheckedBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.clearCheckedBtn.DownBack = null;
            this.clearCheckedBtn.Location = new System.Drawing.Point(1155, 19);
            this.clearCheckedBtn.MouseBack = null;
            this.clearCheckedBtn.Name = "clearCheckedBtn";
            this.clearCheckedBtn.NormlBack = null;
            this.clearCheckedBtn.Size = new System.Drawing.Size(75, 23);
            this.clearCheckedBtn.TabIndex = 52;
            this.clearCheckedBtn.Text = "skinButton1";
            this.clearCheckedBtn.UseVisualStyleBackColor = false;
            this.clearCheckedBtn.Click += new System.EventHandler(this.clearCheckedBtn_Click);
            // 
            // userUpdateBtn
            // 
            this.userUpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.userUpdateBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.userUpdateBtn.DownBack = null;
            this.userUpdateBtn.Location = new System.Drawing.Point(1249, 18);
            this.userUpdateBtn.MouseBack = null;
            this.userUpdateBtn.Name = "userUpdateBtn";
            this.userUpdateBtn.NormlBack = null;
            this.userUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.userUpdateBtn.TabIndex = 51;
            this.userUpdateBtn.Text = "skinButton1";
            this.userUpdateBtn.UseVisualStyleBackColor = false;
            this.userUpdateBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // backupBtn
            // 
            this.backupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backupBtn.BackColor = System.Drawing.Color.Transparent;
            this.backupBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backupBtn.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.backupBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.backupBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.backupBtn.DownBack = global::InventoryApp.Properties.Resources.ic_work_black_24px_pressed;
            this.backupBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.backupBtn.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupBtn.ForeColor = System.Drawing.Color.White;
            this.backupBtn.Location = new System.Drawing.Point(1338, 11);
            this.backupBtn.Margin = new System.Windows.Forms.Padding(0);
            this.backupBtn.MouseBack = global::InventoryApp.Properties.Resources.ic_work_black;
            this.backupBtn.Name = "backupBtn";
            this.backupBtn.NormlBack = global::InventoryApp.Properties.Resources.ic_work_black;
            this.backupBtn.Size = new System.Drawing.Size(35, 35);
            this.backupBtn.TabIndex = 50;
            this.backupBtn.UseVisualStyleBackColor = false;
            this.backupBtn.Click += new System.EventHandler(this.backupBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.button1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button1.DownBack = global::InventoryApp.Properties.Resources.ic_arrow_forward_black_pressed;
            this.button1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(972, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.MouseBack = global::InventoryApp.Properties.Resources.ic_arrow_forward_black_24px;
            this.button1.Name = "button1";
            this.button1.NormlBack = global::InventoryApp.Properties.Resources.ic_arrow_forward_black_24px;
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.button2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.button2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button2.DownBack = global::InventoryApp.Properties.Resources.ic_arrow_back_black_24px;
            this.button2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(844, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.MouseBack = global::InventoryApp.Properties.Resources.ic_arrow_back_black;
            this.button2.Name = "button2";
            this.button2.NormlBack = global::InventoryApp.Properties.Resources.ic_arrow_back_black;
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 48;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addBtn.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.addBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.addBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.addBtn.DownBack = global::InventoryApp.Properties.Resources.ic_add_black_24px_pressed;
            this.addBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.addBtn.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(778, 11);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.MouseBack = global::InventoryApp.Properties.Resources.ic_add_black_24px;
            this.addBtn.Name = "addBtn";
            this.addBtn.NormlBack = global::InventoryApp.Properties.Resources.ic_add_black_24px;
            this.addBtn.Size = new System.Drawing.Size(35, 35);
            this.addBtn.TabIndex = 47;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editBtn.BackColor = System.Drawing.Color.Transparent;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editBtn.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.editBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.editBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.editBtn.DownBack = global::InventoryApp.Properties.Resources.ic_create_black_pressed;
            this.editBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.editBtn.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(678, 12);
            this.editBtn.Margin = new System.Windows.Forms.Padding(0);
            this.editBtn.MouseBack = global::InventoryApp.Properties.Resources.ic_create_black;
            this.editBtn.Name = "editBtn";
            this.editBtn.NormlBack = global::InventoryApp.Properties.Resources.ic_create_black;
            this.editBtn.Size = new System.Drawing.Size(35, 35);
            this.editBtn.TabIndex = 46;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteBtn.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.deleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.deleteBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.deleteBtn.DownBack = global::InventoryApp.Properties.Resources.ic_delete_black_pressed;
            this.deleteBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.deleteBtn.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(728, 11);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(0);
            this.deleteBtn.MouseBack = global::InventoryApp.Properties.Resources.ic_delete_black;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.NormlBack = global::InventoryApp.Properties.Resources.ic_delete_black;
            this.deleteBtn.Size = new System.Drawing.Size(35, 35);
            this.deleteBtn.TabIndex = 45;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBtn.BackRectangle = new System.Drawing.Rectangle(50, 23, 50, 23);
            this.searchBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.searchBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.searchBtn.DownBack = global::InventoryApp.Properties.Resources.ic_search_2x_pressed;
            this.searchBtn.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.searchBtn.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(630, 12);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.MouseBack = global::InventoryApp.Properties.Resources.ic_search_2x;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.NormlBack = global::InventoryApp.Properties.Resources.ic_search_2x;
            this.searchBtn.Size = new System.Drawing.Size(35, 35);
            this.searchBtn.TabIndex = 43;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // lablePage
            // 
            this.lablePage.AutoSize = true;
            this.lablePage.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablePage.Location = new System.Drawing.Point(911, 19);
            this.lablePage.Name = "lablePage";
            this.lablePage.Size = new System.Drawing.Size(39, 19);
            this.lablePage.TabIndex = 17;
            this.lablePage.Text = "0/0";
            // 
            // staffcomboBox
            // 
            this.staffcomboBox.FormattingEnabled = true;
            this.staffcomboBox.Location = new System.Drawing.Point(438, 16);
            this.staffcomboBox.Name = "staffcomboBox";
            this.staffcomboBox.Size = new System.Drawing.Size(166, 27);
            this.staffcomboBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Staff:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Building:";
            // 
            // roomtextBox
            // 
            this.roomtextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtextBox.Location = new System.Drawing.Point(263, 16);
            this.roomtextBox.Name = "roomtextBox";
            this.roomtextBox.Size = new System.Drawing.Size(100, 26);
            this.roomtextBox.TabIndex = 4;
            // 
            // buildingtextBox
            // 
            this.buildingtextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingtextBox.Location = new System.Drawing.Point(99, 16);
            this.buildingtextBox.Name = "buildingtextBox";
            this.buildingtextBox.Size = new System.Drawing.Size(100, 26);
            this.buildingtextBox.TabIndex = 3;
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::InventoryApp.Properties.Resources.backbar;
            this.ClientSize = new System.Drawing.Size(1420, 750);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = global::InventoryApp.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::InventoryApp.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::InventoryApp.Properties.Resources.CloseNormlBack;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaxDownBack = global::InventoryApp.Properties.Resources.MaxDownBack;
            this.MaxMouseBack = global::InventoryApp.Properties.Resources.MaxMouseBack;
            this.MaxNormlBack = global::InventoryApp.Properties.Resources.MaxNormlBack;
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = global::InventoryApp.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::InventoryApp.Properties.Resources.MiniMouseBack;
            this.MinimumSize = new System.Drawing.Size(1420, 750);
            this.MiniNormlBack = global::InventoryApp.Properties.Resources.MiniNormlBack;
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "InventoryPage";
            this.RestoreDownBack = global::InventoryApp.Properties.Resources.RestoreDownBack;
            this.RestoreMouseBack = global::InventoryApp.Properties.Resources.RestoreMouseBack;
            this.RestoreNormlBack = global::InventoryApp.Properties.Resources.RestoreNormlBack;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.InventoryPage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox roomtextBox;
        private System.Windows.Forms.TextBox buildingtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.ComboBox staffcomboBox;
        private System.Windows.Forms.Label lablePage;
        private CCWin.SkinControl.SkinButton searchBtn;
        private CCWin.SkinControl.SkinButton deleteBtn;
        private CCWin.SkinControl.SkinButton editBtn;
        private CCWin.SkinControl.SkinButton addBtn;
        private CCWin.SkinControl.SkinButton button1;
        private CCWin.SkinControl.SkinButton button2;
        private CCWin.SkinControl.SkinButton backupBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton userUpdateBtn;
        private CCWin.SkinControl.SkinButton clearCheckedBtn;
        private CCWin.SkinControl.SkinButton userAddBtn;
    }
}