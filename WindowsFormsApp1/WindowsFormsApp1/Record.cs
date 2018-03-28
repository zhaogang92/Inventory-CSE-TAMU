using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo
{
    public class Record
    {
        public virtual int recordID { get; set; }

        public virtual int staffID { get; set; }

        public virtual int itemID { get; set; }

        public virtual DateTime recordDate { get; set; }

        public virtual bool isReturn { get; set; }
    }
}
