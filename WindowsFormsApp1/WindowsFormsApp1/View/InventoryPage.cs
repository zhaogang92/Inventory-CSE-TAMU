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

using CCWin;
using System.IO;

namespace InventoryApp
{
    public partial class InventoryPage : CCWin.CCSkinMain
    {
        private int dbIndex = 0;

        private List<Object> curItems = null;
        private int curPage = 0;
        private const int PAGE_ITEM_COUNT = 100;

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
        private void showPage(int page)
        {
            var max_page = curItems.Count / PAGE_ITEM_COUNT;
            if (page < 0 || page > max_page)
                return;
        
            curPage = page;
            if (curPage == 0)
                button2.Enabled = false;
            else if (curPage == max_page)
                button1.Enabled = false;
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            lablePage.Text = (curPage + 1) + "/" + (max_page + 1);
            var startIndex = curPage * PAGE_ITEM_COUNT;
            var endIndex = startIndex + PAGE_ITEM_COUNT;
            var len = PAGE_ITEM_COUNT;
            if (endIndex > curItems.Count)
                len = curItems.Count - startIndex;

            itemsDataGridView.DataSource = curItems.GetRange(startIndex, len);
        }

        public void showAllItems(NHibernateRepository repo)
        {
            var items = repo.Query<Item>(Expression.Eq("isDelete", false));
            List<Object> showedItems = new List<Object>();
            for (int i = 0; i < items.Count; ++i)
            {
                Item item = items[i];
                if (item.isDelete)
                    continue;
                showedItems.Add(new
                {
                    Asset = item.asset,
                    Building = item.bldg,
                    Room = item.room,
                    SerialNumber = item.serialNumber,
                    CampusCode = item.campusCode,
                    Description = item.description,
                    TotalCost = item.totalCost,
                    OtherLocation = item.otherLocation,
                    Model = item.Model,
                    Picture = item.picture
                });
            }

            this.curItems = showedItems;
            showPage(0);
            //itemsDataGridView.DataSource = showedItems;
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
            IList<Staff> staffs = repo.Query<Staff>();
            string[] staffName = new string[staffs.Count];

            for (int i = 0; i < staffs.Count; i++)
            {
                staffName[i] = staffs[i].lastName + "," + staffs[i].firstName;
            }
            staffcomboBox.DataSource = staffName;
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
                button1.Enabled = true;
                button2.Enabled = true;

                showAllItems(repo);
            }
            else //show all staffs
            {
                button1.Enabled = false;
                button2.Enabled = false;
                lablePage.Text = "1/1";

                showAllStaffs(repo);
            }

        }


       

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // NHibernateRepository repo = new NHibernateRepository();

            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {

                string name = staffcomboBox.SelectedItem.ToString();
                List<ICriterion> expressions = new List<ICriterion>();
                if (name != "None,None")
                {

                    char[] ch = new char[name.Length];
                    ch = name.ToCharArray();
                    int i;
                    for (i = 0; i < name.Length; i++)
                        if (ch[i] == ',')
                            break;
                    string lastName = name.Substring(0, i);
                    string firstName = name.Substring(i + 1, name.Length - i - 1);
                    if (lastName != "None" && firstName != "None")
                    {
                        expressions.Add(Expression.Like("firstName", "%" + firstName + "%"));
                        expressions.Add(Expression.Like("lastName", "%" + lastName + "%"));
                    }
                }
                if (buildingtextBox.Text != "")
                    expressions.Add(Expression.Like("bldg", buildingtextBox.Text + "%"));
                if (roomtextBox.Text != "")
                    expressions.Add(Expression.Like("room", roomtextBox.Text + "%"));
                //if (startdateTimePicker.Value < enddateTimePicker.Value)
                //    expressions.Add(Expression.Between("acqDate", startdateTimePicker.Value, enddateTimePicker.Value));
                expressions.Add(Expression.Eq("isDelete", false));

                var items = repo.Query<Item>(expressions.ToArray());
                List<Object> showedItems = new List<Object>();
                for (int i = 0; i < items.Count; ++i)
                {
                    Item item = items[i];
                    if (item.isDelete)
                        continue;
                    showedItems.Add(new
                    {
                        Asset = item.asset,
                        Building = item.bldg,
                        Room = item.room,
                        SerialNumber = item.serialNumber,
                        CampusCode = item.campusCode,
                        Description = item.description,
                        TotalCost = item.totalCost,
                        OtherLocation = item.otherLocation,
                        Model = item.Model,
                        Picture = item.picture
                    });
                }

                curItems = showedItems;
                showPage(0);
                //itemsDataGridView.DataSource = showedItems.ToList();
                //itemsDataGridView.DataSource = Items.ToList();

            }
            //search staff
            else
            {
                string name = staffcomboBox.SelectedItem.ToString();
                List<ICriterion> expressions = new List<ICriterion>();
                if (name != "None,None")
                {

                    char[] ch = new char[name.Length];
                    ch = name.ToCharArray();
                    int i;
                    for (i = 0; i < name.Length; i++)
                        if (ch[i] == ',')
                            break;
                    string lastName = name.Substring(0, i);
                    string firstName = name.Substring(i + 1, name.Length - i - 1);
                    if (lastName != "None" && firstName != "None")
                    {
                        expressions.Add(Expression.Like("firstName", "%" + firstName + "%"));
                        expressions.Add(Expression.Like("lastName", "%" + lastName + "%"));
                    }
                }

                var staffs = repo.Query<Staff>(expressions.ToArray());
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

        private void editBtn_Click(object sender, EventArgs e)
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

        private void itemsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            rowindex = e.RowIndex;
            if(itemsDataGridView.Rows[rowindex].Cells["Picture"].Selected == true)
            {
                if (itemsDataGridView.Rows[rowindex].Cells["Picture"].Value != null)
                {

                    Byte[] pic = (Byte[])(itemsDataGridView.Rows[rowindex].Cells["Picture"].Value);
                    View.ShowPicture showPicture = new View.ShowPicture(pic);
                    showPicture.ShowDialog();
                }
                else
                    MessageBox.Show("No corresponding Image!");
               
            }
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                showPage(curPage + 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages[0])
            {
                showPage(curPage - 1);
            }
        }

        private void backup()
        {
            IList<Item> items = repo.Query<Item>(Expression.Eq("isDelete", true));
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "CSV File(*.csv)|*.csv"; ;
            dlg.Title = "Please choose a save location";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dlg.OpenFile(), Encoding.UTF8))
                {
                    sw.WriteLine(Item.getHeader());
                    foreach (Item item in items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

            }
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            backup();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearCheckedBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void userAddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
