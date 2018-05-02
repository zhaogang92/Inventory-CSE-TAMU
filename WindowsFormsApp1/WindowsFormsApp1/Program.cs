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
            

            var loginPage = new Welcome();
            loginPage.ShowDialog();
            if (DialogResult.OK == loginPage.DialogResult)
            {

                var inventoryPage = new InventoryPage(loginPage.user);
                inventoryPage.Size = new System.Drawing.Size(1420, 750);
                Application.Run(inventoryPage);
            }
        }
    }
}
