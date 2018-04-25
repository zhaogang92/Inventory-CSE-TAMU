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
            NHibernateRepository repo = new NHibernateRepository();
            int oldCount = repo.Query<Item>().Count;
            var item2 = new Item()
            {
                asset = "3143",
                campusCode = 8,
                description = "This is a good one",
                bldg = "332-00445",
                room = "312B",
                otherLocation = "otherlocation",
                acqDate = new DateTime(2008, 8, 29),
                totalCost = Convert.ToDecimal(330044.04),
                Model = "Model",
                serialNumber = "FFF00000422",
                isDelete = false,
                comments = "comments",

            };
            IList<Staff> st = repo.Query<Staff>();
            item2.Staffs = st[0];
            repo.SaveOrUpdate(item2);
        }
    }
}
