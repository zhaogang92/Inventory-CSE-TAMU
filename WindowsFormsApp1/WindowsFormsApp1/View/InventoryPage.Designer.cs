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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddSearchTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inventoryDBGridView = new CCWin.SkinControl.SkinDataGridView();
            this.SearchBtn = new CCWin.SkinControl.SkinButton();
            this.AssertNumberTxt = new CCWin.SkinControl.RtfRichTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.Properties = new CCWin.SkinControl.SkinComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.DeleteBtn = new CCWin.SkinControl.SkinButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSearchTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSearchTab
            // 
            this.AddSearchTab.Controls.Add(this.tabPage1);
            this.AddSearchTab.Controls.Add(this.tabPage2);
            this.AddSearchTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSearchTab.Location = new System.Drawing.Point(8, 26);
            this.AddSearchTab.Margin = new System.Windows.Forms.Padding(2);
            this.AddSearchTab.Name = "AddSearchTab";
            this.AddSearchTab.Padding = new System.Drawing.Point(100, 10);
            this.AddSearchTab.SelectedIndex = 0;
            this.AddSearchTab.Size = new System.Drawing.Size(837, 362);
            this.AddSearchTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inventoryDBGridView);
            this.tabPage1.Controls.Add(this.SearchBtn);
            this.tabPage1.Controls.Add(this.AssertNumberTxt);
            this.tabPage1.Controls.Add(this.skinLabel1);
            this.tabPage1.Controls.Add(this.Properties);
            this.tabPage1.Location = new System.Drawing.Point(4, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(829, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search/Edit/Delete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // inventoryDBGridView
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.inventoryDBGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.inventoryDBGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.inventoryDBGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inventoryDBGridView.ColumnFont = null;
            this.inventoryDBGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDBGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.inventoryDBGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDBGridView.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventoryDBGridView.DefaultCellStyle = dataGridViewCellStyle19;
            this.inventoryDBGridView.EnableHeadersVisualStyles = false;
            this.inventoryDBGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.inventoryDBGridView.HeadFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDBGridView.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.inventoryDBGridView.Location = new System.Drawing.Point(3, 38);
            this.inventoryDBGridView.Name = "inventoryDBGridView";
            this.inventoryDBGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inventoryDBGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.inventoryDBGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.inventoryDBGridView.RowTemplate.Height = 23;
            this.inventoryDBGridView.Size = new System.Drawing.Size(821, 286);
            this.inventoryDBGridView.TabIndex = 4;
            this.inventoryDBGridView.TitleBack = null;
            this.inventoryDBGridView.TitleBackColorBegin = System.Drawing.Color.White;
            this.inventoryDBGridView.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BaseColor = System.Drawing.Color.White;
            this.SearchBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SearchBtn.DownBack = null;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(717, 4);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.MouseBack = null;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.NormlBack = null;
            this.SearchBtn.Size = new System.Drawing.Size(100, 25);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // AssertNumberTxt
            // 
            this.AssertNumberTxt.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.AssertNumberTxt.Location = new System.Drawing.Point(445, 4);
            this.AssertNumberTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AssertNumberTxt.Name = "AssertNumberTxt";
            this.AssertNumberTxt.Size = new System.Drawing.Size(166, 26);
            this.AssertNumberTxt.TabIndex = 2;
            this.AssertNumberTxt.Text = "";
            this.AssertNumberTxt.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(281, 6);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 21);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "equals to";
            // 
            // Properties
            // 
            this.Properties.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Properties.FormattingEnabled = true;
            this.Properties.Location = new System.Drawing.Point(4, 2);
            this.Properties.Margin = new System.Windows.Forms.Padding(2);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(215, 31);
            this.Properties.TabIndex = 0;
            this.Properties.Text = "Asset Number";
            this.Properties.WaterText = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.skinButton1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(829, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New Record";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.White;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(671, 283);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(2);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(158, 35);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.Text = "Add Record";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58291F));
            this.tableLayoutPanel1.Controls.Add(this.skinLabel4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel8, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.skinLabel9, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 61);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(549, 0);
            this.skinLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(124, 21);
            this.skinLabel4.TabIndex = 13;
            this.skinLabel4.Text = "Other Location";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(2, 144);
            this.skinLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(119, 21);
            this.skinLabel10.TabIndex = 17;
            this.skinLabel10.Text = "Serial Number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 30);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 30);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 146);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 30);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(413, 2);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 30);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(413, 74);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 30);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(413, 146);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 30);
            this.textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(685, 2);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 30);
            this.textBox7.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(685, 74);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(133, 30);
            this.textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(685, 146);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(133, 30);
            this.textBox8.TabIndex = 7;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(2, 0);
            this.skinLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(124, 21);
            this.skinLabel2.TabIndex = 9;
            this.skinLabel2.Text = "Assert Number";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(2, 72);
            this.skinLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(96, 21);
            this.skinLabel3.TabIndex = 10;
            this.skinLabel3.Text = "Description";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(276, 0);
            this.skinLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(123, 21);
            this.skinLabel5.TabIndex = 12;
            this.skinLabel5.Text = "Room Number";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(276, 72);
            this.skinLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(95, 21);
            this.skinLabel6.TabIndex = 13;
            this.skinLabel6.Text = "User Name";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(549, 72);
            this.skinLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(72, 21);
            this.skinLabel7.TabIndex = 14;
            this.skinLabel7.Text = "Building";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(549, 144);
            this.skinLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(87, 21);
            this.skinLabel8.TabIndex = 15;
            this.skinLabel8.Text = "Total Cost";
            this.skinLabel8.Click += new System.EventHandler(this.skinLabel8_Click);
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(276, 144);
            this.skinLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(80, 21);
            this.skinLabel9.TabIndex = 16;
            this.skinLabel9.Text = "Acq Date";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.BaseColor = System.Drawing.Color.White;
            this.DeleteBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.DeleteBtn.DownBack = null;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(611, 392);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.MouseBack = null;
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.NormlBack = null;
            this.DeleteBtn.Size = new System.Drawing.Size(234, 25);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete Selected Record";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDataToolStripMenuItem,
            this.staffInformationToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.dataToolStripMenuItem.Text = "Import";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // importDataToolStripMenuItem
            // 
            this.importDataToolStripMenuItem.Name = "importDataToolStripMenuItem";
            this.importDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importDataToolStripMenuItem.Text = "Inventory List";
            this.importDataToolStripMenuItem.Click += new System.EventHandler(this.importInventoryDataMenuClick);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // staffInformationToolStripMenuItem
            // 
            this.staffInformationToolStripMenuItem.Name = "staffInformationToolStripMenuItem";
            this.staffInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffInformationToolStripMenuItem.Text = "Staff Information";
            this.staffInformationToolStripMenuItem.Click += new System.EventHandler(this.importStaffDataMenuClick);
            // 
            // InventoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 422);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddSearchTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InventoryPage";
            this.Text = "Inventory";
            this.AddSearchTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDBGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AddSearchTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CCWin.SkinControl.RtfRichTextBox AssertNumberTxt;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox Properties;
        private CCWin.SkinControl.SkinButton SearchBtn;
        private CCWin.SkinControl.SkinButton DeleteBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinDataGridView inventoryDBGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInformationToolStripMenuItem;
    }
}