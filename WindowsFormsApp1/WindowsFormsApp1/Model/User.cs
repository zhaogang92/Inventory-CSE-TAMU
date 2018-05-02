using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Model
{
    public class User
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Password { get; set; }
        public virtual bool IsAuthorized { get; set; }
    }
}
