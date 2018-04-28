using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using InventoryApp.Common;
using InventoryApp.Model;
using System.Data.SQLite;
using NHibernate.Criterion;

namespace InventoryApp.View
{
    public partial class ShowPicture : Form
    {
        Byte[] pic;
        public ShowPicture(Byte[] picture)
        {
            InitializeComponent();
            pic = picture;

        }

        private void ShowPicture_Load(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(pic);
            ms.Write(pic, 0, pic.Length);
            pictureBox.Image = Image.FromStream(ms);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
