using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using InventoryApp.Controller;
//using InventoryApp.Model;

namespace InventoryApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UserInfoData userInfoData = new UserInfoData();
            bool result = userInfoData.AddUserInfo(new UserInfo()
            {
                Address = "北京",
                Age = 25,
                Gender = true,
                UserName = "wolfy"
            });

            var loginPage = new Welcome();
            loginPage.ShowDialog();
            if (DialogResult.OK == loginPage.DialogResult)
            {
                var inventoryPage = new InventoryPage(loginPage.DBIndex);
                Application.Run(inventoryPage);
            }
        }
    }
}
