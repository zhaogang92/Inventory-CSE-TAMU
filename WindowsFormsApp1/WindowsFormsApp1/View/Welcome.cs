using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using CCWin;

using InventoryApp.Common;
using NHibernate.Criterion;
using InventoryApp.Model;

namespace InventoryApp
{
    public partial class Welcome : CCWin.CCSkinMain
    {
        public int DBIndex { get; set; }

        public Welcome()
        {
            InitializeComponent();
        }

        private bool validateUser(String userName, String password)
        {
            //if (userName == "admin" && password =="admin")
            //    return true;
            //else
            //    return false;
            var repo = new NHibernateRepository();
            var users = repo.Query<User>(Expression.Eq("Name", userName));
            if (1 != users.Count)
            {
                return false;
            }
            if (users[0].Password != password)
            {
                return false;
            }
            return true;
        }

        private void loginBtnClick(object sender, EventArgs e)
        {
            
            if (!validateUser(this.userNameTextbox.Text, this.pwdTextbox.Text))
            {
                CCWin.MessageBoxEx.Show("Username/password is incorrect!", "Error", MessageBoxButtons.OK);
                return;
            }

            //DBIndex = this.ChoosedbCb.SelectedIndex;
            //if (DBIndex == -1)
            //{
            //    CCWin.MessageBoxEx.Show("Please select one database!", "Error", MessageBoxButtons.OK);
            //    return;
            //}

            this.DialogResult = DialogResult.OK;

            this.Close();
            //InventoryPage inventoryPage = new InventoryPage();
            //inventoryPage.Show();

            return;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!validateUser(this.userNameTextbox.Text, this.pwdTextbox.Text))
            {
                CCWin.MessageBoxEx.Show("Username/password is incorrect!", "Error", MessageBoxButtons.OK);
                return;
            }

           
            this.DialogResult = DialogResult.OK;

            this.Close();
            //InventoryPage inventoryPage = new InventoryPage();
            //inventoryPage.Show();

            return;
        }

        //public static MySqlConnection connection;
        //MySql.Data.MySqlClient.MySqlCommand command;
        //private void Welcome_Load(object sender, EventArgs e)
        //{
        //    string connString = "server=database-new.cse.tamu.edu;database=shi_wei652327;uid=shi_wei652327;pwd=shi_wei652327";
        //    MySqlConnection connection = new MySqlConnection(connString);

        //    try
        //    {
        //        connection.Open();
        //        MessageBox.Show("successfully connect to database");
        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }




        //}
    }
}
