using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDemo
{
    public class Item
    {
        public virtual int asset { get; set; }

        public virtual string description { get; set; }

        public virtual string bldg { get; set; }

        public virtual string room { get; set; }

        public virtual string otherLocation { get; set; }

        public virtual DateTime acqDate { get; set; }

        public virtual decimal totalCost { get; set; }

        public virtual string Model { get; set; }

        public virtual string serialNumber { get; set; }

        public virtual string groupCode { get; set; }

        public virtual bool isDelete { get; set; }

        public virtual byte[] picture { get; set; }
    }
}
