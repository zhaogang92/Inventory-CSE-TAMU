using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Model
{
    public class ViewItem
    {
        public bool IsChecked { get; set; }
        public string Asset { get; set; }
        public string Building { get; set; }
        public string Room { get; set; }
        public string SerialNumber { get; set; }
        public int CampusCode { get; set; }
        public string Description { get; set; }
        public decimal TotalCost { get; set; }
        public string OtherLocation { get; set; }
        public string Model { get; set; }
        public byte[] Picture { get; set; }
    }
}
