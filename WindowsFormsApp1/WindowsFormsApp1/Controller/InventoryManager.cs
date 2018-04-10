using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;
using LinqToExcel;
using InventoryApp.Controller;

namespace InventoryApp
{
    class DataImporter
    {
        public bool importInventoryData(String fileName)
        {
            return true;
        }

        public bool importStaffData(String fileName)
        {
            var excel = new ExcelQueryFactory(fileName);
            var items = from row in excel.Worksheet()
                        let item = new Staff
                        {
                            lastName = Convert.ToString(row["Name"]).Split(',')[0],
                            firstName = Convert.ToString(row["Name"]).Split(',')[1],
                            email = Convert.ToString(row["Email"]),
                            phone = Convert.ToString(row["Phone"]),
                            location = Convert.ToString(row["Location"])
                        }
                        select item;
            return CreateStaffs(items.ToList<Staff>());
        }

        public bool CreateInventories(IList<Item> inventories)
        {
            //TODO: replace it with NHibernateRepository
            return DBHelper.getDBHelper().CreateRecords<Item>(inventories);
        }

        public bool CreateStaffs(IList<Staff> staffs)
        {
            //TODO: replace it with NHibernateRepository
            return DBHelper.getDBHelper().CreateRecords<Staff>(staffs);
        }

        public IList<Item> QueryInventory()
        {
            throw new NotImplementedException();
        }

        public IList<Staff> QueryStaff()
        {
            throw new NotImplementedException();
        }
    }
}
