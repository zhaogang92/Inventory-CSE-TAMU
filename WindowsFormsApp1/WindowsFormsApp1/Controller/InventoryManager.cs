using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;

namespace InventoryApp
{
    class InventoryManager
    {
        public void importData(String fileName)
        {

        }

        public bool CreateInventories(IList<Inventory> inventories)
        {
            using (var session = SessionFactory.OpenSession)
            {
                using (var tx = session.BeginTransaction())
                {
                    foreach (var inventory in inventories)
                    {
                        session.Save(inventory);
                    }
                    tx.Commit();
                }
                session.Close();
            }
            return false;
        }

        public bool CreateStaffs(IList<Staff> staffs)
        {
            return false;
        }

        public IList<Inventory> QueryInventory()
        {
            throw new NotImplementedException();
        }

        public IList<Staff> QueryStaff()
        {
            throw new NotImplementedException();
        }
    }
}
