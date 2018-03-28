using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCWin;

namespace InventoryApp
{
    public partial class InventoryPage : Form
    {
        private int dbIndex = 0;

        public InventoryPage(int dbIndex)
        {
            InitializeComponent();

            this.dbIndex = dbIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel8_Click(object sender, EventArgs e)
        {

        }

        private void importInventoryDataMenuClick(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
        }

        private void importStaffDataMenuClick(object sender, EventArgs e)
        {

        }
    }
}
