using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo
{
    public class LendRecord
    {
        public virtual int lendRecordID { get; set; }

        public virtual int staffID { get; set; }

        public virtual int itemID { get; set; }

        public virtual DateTime lendRecordDate { get; set; }
    }
}
