using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Controller
{
    public class DBHelper
    {

        private static DBHelper _dbHelper = null;

        private DBHelper() { }

        ~DBHelper() { }
        
        public static DBHelper getDBHelper()
        {
            if (_dbHelper == null)
            {
                _dbHelper = new DBHelper();
            }
            return _dbHelper;
        }
        
        public bool CreateRecords<T>(IList<T> records)
        {
            try
            {
                using (var session = SessionFactory.OpenSession)
                {
                    using (var tx = session.BeginTransaction())
                    {
                        foreach (var record in records)
                        {
                            session.Save(record);
                        }
                        tx.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
                return false;
            }
            return true;
        }
    }
}
