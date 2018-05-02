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
        bool isAddNewUser;
        User user;
        bool isLoad = false;
        
        public UserView(bool isAddNew,User us)
        {
            InitializeComponent();
            isAddNewUser = isAddNew;
            user = us;
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
                var users = repo.Query<User>(Expression.Eq("Name", userNametextBox.Text));
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
            if (!isAddNewUser && isLoad)
            {
                NHibernateRepository repo = new NHibernateRepository();
                var users = repo.Query<User>(Expression.Eq("Name", userNametextBox.Text));
                if (users.Count != 0)
                {
                    MessageBox.Show("This username has already existed!");
                    return;
                }
                else
                    user.Name = userNametextBox.Text;
            }


        }

        private void UserView_Load(object sender, EventArgs e)
        {
            if (isAddNewUser)
            {
                AddBtn.Enabled = true;
                UpdateBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = false;
                UpdateBtn.Enabled = true;
                userNametextBox.Text = user.Name;
                passwordtextBox.Text = user.Password;
                confirmPasswordtextBox.Text = user.Password;
                authorizedcheckBox.Checked = user.IsAuthorized;
                isLoad = true;
               

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (passwordtextBox.Text != confirmPasswordtextBox.Text)
            {
                MessageBox.Show("Please make sure the passwords are the same");
                return;
            }
            else
                user.Password = passwordtextBox.Text;

            NHibernateRepository repo = new NHibernateRepository();
            repo.SaveOrUpdate(user);
            this.DialogResult = DialogResult.OK;
            this.Close();
            return;
        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {
           /* if (!isAddNewUser && isLoad)
            {
                if (passwordtextBox.Text != confirmPasswordtextBox.Text)
                {
                    MessageBox.Show("Please make sure the passwords are the same");
                    return;
                }
                else
                    user.Password = passwordtextBox.Text;
            }*/
        }
    }
}
