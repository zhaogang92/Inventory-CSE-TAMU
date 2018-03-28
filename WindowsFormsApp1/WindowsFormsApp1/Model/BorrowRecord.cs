using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class BorrowRecord
    {
        public virtual int borrowRecordID { get; set; }

        public virtual int staffID { get; set; }

        public virtual int itemID { get; set; }

        public virtual DateTime borrowRecordDate { get; set; }
    }
}
