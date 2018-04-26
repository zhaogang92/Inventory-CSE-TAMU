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
        NHibernateRepository repo = new NHibernateRepository();
        public InventoryPage()
        {
            InitializeComponent();

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel8_Click(object sender, EventArgs e)
        {

        }

        /*private void importInventoryDataMenuClick(object sender, EventArgs e)
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
        */
        public void showAllItems(NHibernateRepository repo)
        {
            var items = repo.Query<Item>(Expression.Eq("isDelete", false));
            var showedItems = from item in items
                              let showedItem = new
                              {
                                  Asset = item.asset,
                                  Building = item.bldg,
                                  Room = item.room,
                                  SerialNumber = item.serialNumber,
                                  CampusCode = item.campusCode,
                                  Description = item.description,
                                  TotalCost = item.totalCost,
                                  OtherLocation = item.otherLocation,
                                  Model = item.Model
                              }
                              select showedItem;
            itemsDataGridView.DataSource = showedItems.ToList();
            return;
        }

        public void showAllStaffs(NHibernateRepository repo)
        {
            var staffs = repo.Query<Staff>();
            var showedStaffs = from staff in staffs
                               let showedStaff = new
                               {
                                   lastname = staff.lastName,
                                   firstname = staff.firstName,
                                   groupcode = staff.groupCode,
                                   email = staff.email,
                                   phone = staff.phone,
                                   location = staff.location
                               }
                               select showedStaff;
            staffDataGridView.DataSource = showedStaffs.ToList();
            return;
        }

        private void InventoryPage_Load(object sender, EventArgs e)
        {
            NHibernateRepository repo = new NHibernateRepository();
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                showAllItems(repo);
            }
            editBtn.Enabled = false;
        }

        private void itemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //show all items
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                /*var items = repo.Query<Item>(Expression.Eq("isDelete",false));
                var showedItems = from item in items
                                  let showedItem = new
                                  {
                                      Asset = item.asset,
                                      Building = item.bldg,
                                      Room = item.room,
                                      SerialNumber = item.serialNumber,
                                      CampusCode = item.campusCode,
                                      Description = item.description,
                                      TotalCost = item.totalCost,
                                      OtherLocation = item.otherLocation,
                                      Model = item.Model
                                  }
                                  select showedItem;
                itemsDataGridView.DataSource = showedItems.ToList();*/
                showAllItems(repo);
            }
            else //show all staffs
            {
                showAllStaffs(repo);
            }

        }

        private List<TextBox> checkHowmanyTextBoxUsed()
        {
            int count = 0;
            List<TextBox> textBoxList = new List<TextBox>();
            if (textBox1.Text != "") 
                textBoxList.Add(textBox1);
            if (textBox2.Text != "")
                textBoxList.Add(textBox2);
            if (textBox4.Text != "")
                textBoxList.Add(textBox4);
            return textBoxList;
        }

       

        private void searchBtn_Click(object sender, EventArgs e)
        {
           // NHibernateRepository repo = new NHibernateRepository();

            //search items
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                List<TextBox> textBoxList = checkHowmanyTextBoxUsed();
                int count = textBoxList.Count;
                if (count == 0)
                    MessageBox.Show("Please enter search query");
                else
                {
                    ICriterion[] expressions = new ICriterion[count+1];

                    for (int i = 0; i < count-1; i++)
                        expressions[i] = Expression.Eq("firstName", textBoxList[i].Text);
                    expressions[count-1] = Expression.Eq("isDelete", false);
                    var items = repo.Query<Item>(expressions);
                    var showedItems = from item in items
                                      let showedItem = new
                                      {
                                          Asset = item.asset,
                                          Building = item.bldg,
                                          Room = item.room,
                                          SerialNumber = item.serialNumber,
                                          CampusCode = item.campusCode,
                                          Description = item.description,
                                          TotalCost = item.totalCost,
                                          OtherLocation = item.otherLocation,
                                          Model = item.Model
                                      }
                                      select showedItem;
                    itemsDataGridView.DataSource = showedItems.ToList();
                    //itemsDataGridView.DataSource = Items.ToList();
                }
            }
            //search staff
            else
            {
                if (textBox4.Text == "")
                    MessageBox.Show("Please enter staff's name");
                else
                {
                    ICriterion expression = Expression.Like("firstName",textBox4.Text);
                    var staffs = repo.Query<Staff>(expression);
                    staffDataGridView.DataSource = staffs.ToList();
                    
                }
            }
        }
        //delete one item from database, actually set isDelete = true
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                
                {
                    DialogResult result = MessageBox.Show(this, "Are you going to delete this item from database?", "Please confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        ICriterion[] expressions = new ICriterion[2];
                        expressions[0] = Expression.Eq("asset", itemsDataGridView.Rows[rowindex].Cells[0].Value);
                        expressions[1] = Expression.Eq("isDelete", false);
                        IList<Item> items = repo.Query<Item>(expressions);
                        if (items.Count > 1)
                            MessageBox.Show("There exist at least two items with the same asset,please check it");
                        else
                        {
                            items[0].isDelete = true;
                            repo.Update(items[0]);
                            showAllItems(repo);
                        }
                    }
                }
            }
            else
                MessageBox.Show("You don't have right to delete staff!");
        }

        int rowindex;
        private void staffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editBtn.Enabled = true;
            rowindex = e.RowIndex;
           
            

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           // NHibernateRepository repo = new NHibernateRepository();
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                View.ItemView itemView = new View.ItemView(true, null);
                itemView.ShowDialog();
                showAllItems(repo);
            }
            else
            {
                View.StaffView staffView = new View.StaffView(true, null);
                staffView.ShowDialog();
                /*var staffs = repo.Query<Staff>();
                var showedStaffs = from staff in staffs
                                   let showedStaff = new
                                   {
                                       lastname = staff.lastName,
                                       firstname = staff.firstName,
                                       groupcode = staff.groupCode,
                                       email = staff.email,
                                       phone = staff.phone,
                                       location = staff.location

                                   }
                                   select showedStaff;
                staffDataGridView.DataSource = showedStaffs.ToList();*/
                showAllStaffs(repo);

            }
            

            

        }
       /* private void editBtn_Click(object sender, EventArgs e)
        {
            
        }*/

        private void itemsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editBtn.Enabled = true;
            rowindex = e.RowIndex;
            string strid = Convert.ToString(itemsDataGridView.CurrentCell.RowIndex);
            //MessageBox.Show(strid);
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
               // NHibernateRepository repo = new NHibernateRepository();
                ICriterion[] expressions = new ICriterion[2];
                expressions[0] = Expression.Eq("asset", itemsDataGridView.Rows[rowindex].Cells[0].Value);
                expressions[1] = Expression.Eq("isDelete", false);
                IList<Item> items = repo.Query<Item>(expressions);
                View.ItemView itemView = new View.ItemView(false, items[0]);
                itemView.ShowDialog();
                editBtn.Enabled = false;
                showAllItems(repo);
            }
            else
            {
                ICriterion criterion = Expression.Eq("groupCode", staffDataGridView.Rows[rowindex].Cells[2].Value);
                IList<Staff> staffs= repo.Query<Staff>(criterion);
                View.StaffView staffView = new View.StaffView(false, staffs[0]);
                staffView.ShowDialog();
                editBtn.Enabled = false;
                showAllStaffs(repo);

            }
        }
    }
}
