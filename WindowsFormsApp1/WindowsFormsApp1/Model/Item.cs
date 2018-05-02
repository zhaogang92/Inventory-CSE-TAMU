using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Model
{
    public class Item
    {
        public virtual int itemID { get; set; }

        public virtual string asset { get; set; }

        public virtual bool isChecked { get; set; }

        public virtual int campusCode { get; set; }
        
        public virtual string description { get; set; }

        public virtual string bldg { get; set; }

        public virtual string room { get; set; }

        public virtual string otherLocation { get; set; }

        public virtual DateTime acqDate { get; set; }

        public virtual decimal totalCost { get; set; }

        public virtual string Model { get; set; }

        public virtual string serialNumber { get; set; }

        public virtual string groupCode { get; set; }

        public virtual string lastName { get; set; }

        public virtual string firstName { get; set; }

        public virtual bool isDelete { get; set; }

        public virtual string comments { get; set; }

        public virtual byte[] picture { get; set; }
        
        public virtual Staff Staffs { get; set; }

        public static string getHeader()
        {
            return "Asset, Campus Code, Description, Bldg, Room, Other Location, Acquire Date, Total Cost, Model, SerialNumber, " +
                "Group Code, Staff Name, Comments";
        }

        public override string ToString()
        {
            char[] ts = new char[] { '?' };
            return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, ${7}, {8}, {9}, {10}, {11}, {12}",
                asset, campusCode, description, bldg, room, otherLocation,
            acqDate.ToShortDateString(), totalCost, Model, serialNumber, groupCode, Staffs.lastName + ", " + Staffs.firstName, comments);
        }
    }
}
