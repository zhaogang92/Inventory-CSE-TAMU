using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using CCWin;


using InventoryApp.Common;
using InventoryApp.Model;
using System.Data.SQLite;
using NHibernate.Criterion;

namespace InventoryApp
{
    public partial class InventoryPage : System.Windows.Forms.Form
    {
        private int dbIndex = 0;

        public InventoryPage(int dbIndex)
        {
            InitializeComponent();

            this.dbIndex = dbIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel8_Click(object sender, EventArgs e)
        {

        }

        private void importInventoryDataMenuClick(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            dlg.Multiselect = false;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                var controller = new DataImporter();
                if (!controller.importInventoryData(dlg.FileName))
                {
                    CCWin.MessageBoxEx.Show("Data import failed, please check your Excel data!", "Error",
                        MessageBoxButtons.OK);
                }
            }
        }

        private void importStaffDataMenuClick(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            dlg.Multiselect = false;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                var controller = new DataImporter();
                if (!controller.importStaffData(dlg.FileName))
                {
                    CCWin.MessageBoxEx.Show("Data import failed, please check your Excel data!", "Error",
                        MessageBoxButtons.OK);
                }
            }
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {
            NHibernateRepository repo = new NHibernateRepository();
            var items = repo.Query<Item>();
            var showedItems = from item in items
                              let showedItem = new
                              {
                                  Asset=item.asset,
                                  Building=item.bldg,
                                  Room=item.room,
                                  SerialNumber=item.serialNumber,
                                  CampusCode=item.campusCode,
                                  Description=item.description,
                                  TotalCost=item.totalCost,
                                  OtherLocation=item.otherLocation,
                                  Model=item.Model
                              }
                              select showedItem;
            itemsDataGridView.DataSource = showedItems.ToList();
        }
    }
}
