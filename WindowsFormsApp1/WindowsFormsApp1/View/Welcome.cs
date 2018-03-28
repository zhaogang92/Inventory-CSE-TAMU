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
    public partial class Welcome : Form
    {
        public int DBIndex { get; set; }

        public Welcome()
        {
            InitializeComponent();
        }

        private bool validateUser(String userName, String password)
        {
            return true;
        }

        private void loginBtnClick(object sender, EventArgs e)
        {
            if (!validateUser(this.userNameTextbox.Text, this.pwdTextbox.Text))
            {
                CCWin.MessageBoxEx.Show("Username/password is incorrect!", "Error", MessageBoxButtons.OK);
                return;
            }

            DBIndex = this.ChoosedbCb.SelectedIndex;
            if (DBIndex == -1)
            {
                CCWin.MessageBoxEx.Show("Please select one database!", "Error", MessageBoxButtons.OK);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

            return;
        }
    }
}
