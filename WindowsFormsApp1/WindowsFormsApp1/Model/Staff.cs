﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    public class Staff
    {
        public virtual int staffID { get; set; }

        public virtual string lastName { get; set; }

        public virtual string firstName { get; set; }

        public virtual string email { get; set; }

        public virtual string phone { get; set; }

        public virtual string location { get; set; }
    }
}