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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.staffcomboBox = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.enddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomtextBox = new System.Windows.Forms.TextBox();
            this.buildingtextBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.lablePage = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel2.Controls.Add(this.lablePage);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.staffcomboBox);
            this.splitContainer1.Panel2.Controls.Add(this.addBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.enddateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.startdateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.roomtextBox);
            this.splitContainer1.Panel2.Controls.Add(this.buildingtextBox);
            this.splitContainer1.Panel2.Controls.Add(this.searchBtn);
            this.splitContainer1.Panel2.Controls.Add(this.deleteBtn);
            this.splitContainer1.Panel2.Controls.Add(this.editBtn);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1532, 668);
            this.splitContainer1.SplitterDistance = 606;
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
            this.tabControl.Size = new System.Drawing.Size(1532, 606);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.itemsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1524, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsDataGridView
            // 
            this.itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.itemsDataGridView.Name = "itemsDataGridView";
            this.itemsDataGridView.Size = new System.Drawing.Size(1518, 559);
            this.itemsDataGridView.TabIndex = 0;
            this.itemsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellClick);
            this.itemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellContentClick);
            this.itemsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDataGridView_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.staffDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1524, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Staffs";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(1518, 559);
            this.staffDataGridView.TabIndex = 1;
            this.staffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridView_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1224, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Prev";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1317, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // staffcomboBox
            // 
            this.staffcomboBox.FormattingEnabled = true;
            this.staffcomboBox.Location = new System.Drawing.Point(712, 16);
            this.staffcomboBox.Name = "staffcomboBox";
            this.staffcomboBox.Size = new System.Drawing.Size(121, 36);
            this.staffcomboBox.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(1143, 14);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 35);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "to";
            // 
            // enddateTimePicker
            // 
            this.enddateTimePicker.CalendarFont = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddateTimePicker.CustomFormat = "";
            this.enddateTimePicker.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddateTimePicker.Location = new System.Drawing.Point(548, 16);
            this.enddateTimePicker.Name = "enddateTimePicker";
            this.enddateTimePicker.Size = new System.Drawing.Size(117, 36);
            this.enddateTimePicker.TabIndex = 12;
            // 
            // startdateTimePicker
            // 
            this.startdateTimePicker.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateTimePicker.CustomFormat = "";
            this.startdateTimePicker.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdateTimePicker.Location = new System.Drawing.Point(397, 16);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(119, 36);
            this.startdateTimePicker.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(672, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Staff:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Room:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Building:";
            // 
            // roomtextBox
            // 
            this.roomtextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomtextBox.Location = new System.Drawing.Point(241, 16);
            this.roomtextBox.Name = "roomtextBox";
            this.roomtextBox.Size = new System.Drawing.Size(100, 36);
            this.roomtextBox.TabIndex = 4;
            // 
            // buildingtextBox
            // 
            this.buildingtextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildingtextBox.Location = new System.Drawing.Point(79, 16);
            this.buildingtextBox.Name = "buildingtextBox";
            this.buildingtextBox.Size = new System.Drawing.Size(100, 36);
            this.buildingtextBox.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Location = new System.Drawing.Point(849, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 35);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1041, 14);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 35);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(945, 14);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 35);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click_1);
            // 
            // lablePage
            // 
            this.lablePage.AutoSize = true;
            this.lablePage.Location = new System.Drawing.Point(1426, 16);
            this.lablePage.Name = "lablePage";
            this.lablePage.Size = new System.Drawing.Size(51, 28);
            this.lablePage.TabIndex = 17;
            this.lablePage.Text = "0/0";
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::InventoryApp.Properties.Resources.backbar;
            this.ClientSize = new System.Drawing.Size(1540, 700);
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
            this.MinimumSize = new System.Drawing.Size(808, 452);
            this.MiniNormlBack = global::InventoryApp.Properties.Resources.MiniNormlBack;
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "InventoryPage";
            this.RestoreDownBack = global::InventoryApp.Properties.Resources.RestoreDownBack;
            this.RestoreMouseBack = global::InventoryApp.Properties.Resources.RestoreMouseBack;
            this.RestoreNormlBack = global::InventoryApp.Properties.Resources.RestoreNormlBack;
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
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomtextBox;
        private System.Windows.Forms.TextBox buildingtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker enddateTimePicker;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView itemsDataGridView;
        private System.Windows.Forms.ComboBox staffcomboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lablePage;
    }
}