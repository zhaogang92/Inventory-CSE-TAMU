using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Common;
using InventoryApp.Model;
using System.Data.SQLite;
using NHibernate.Criterion;

using CCWin;

namespace InventoryApp.View
{
    public partial class UserView : CCSkinMain
    {
        public UserView(bool isAddNew)
        {
            InitializeComponent();
        }

        private bool Authorize(String str)
        {
            if (str == "admin")
                return true;
            else
                return false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            NHibernateRepository repo = new NHibernateRepository();
            if (passwordtextBox.Text != confirmPasswordtextBox.Text)
            {
                MessageBox.Show("Please enter the same passord");
                return;
            }
            if (userNametextBox.Text != "")
            {
                var users = repo.Query<User>(Expression.Eq("userName", userNametextBox.Text));
                if (users.Count > 0)
                {
                    MessageBox.Show("This user has already existed!");
                    return;
                }
                else
                {
                    var newUser = new User
                    {
                        Name = userNametextBox.Text,
                        Password = passwordtextBox.Text,
                        IsAuthorized = authorizedcheckBox.Checked
                    };
                    repo.Save(newUser);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;


                }


            }
        }

        private void userNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserView_Load(object sender, EventArgs e)
        {

        }
    }
}
