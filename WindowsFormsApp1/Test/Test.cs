using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InventoryApp.Model;
using InventoryApp.Common;

namespace Test
{
    static class Test
    {
        [STAThread]
        static void Main()
        {
            Console.WriteLine("The path is: ");
            Console.WriteLine(System.IO.Path.GetFullPath(@"../../../WindowsFormsApp1/Data/database.db"));

            var staff = new Staff()
            {
                groupCode = "TestGroupCode",
                lastName = "Hello",
                firstName = "World",
                email = "Hello_world@gmail.com",
                phone = "979979979",
                location = "HRBB"
            };

            NHibernateRepository repo = new NHibernateRepository();
            repo.DeleteByQuery("select * from Item;");
            repo.SaveOrUpdate(staff);
        }
    }
}
