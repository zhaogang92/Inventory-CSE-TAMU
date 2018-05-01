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
using CCWin;

namespace InventoryApp.View
{
    public partial class ItemView : CCWin.CCSkinMain
    {
        private bool isAddNew;
        private Item it;
        NHibernateRepository repo = new NHibernateRepository();
        int index;
        Byte[] pic;
        string[] staffName;
        private bool isbinding = false;
        public ItemView(bool IsAddNewItem, Item item)
        {
            InitializeComponent();
            isAddNew = IsAddNewItem;
            it = item;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void ItemView_Load(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                Addbtn.Enabled = true;
                Updatebtn.Enabled = false;
                IList<Staff> staffs = repo.Query<Staff>();
                staffName = new string[staffs.Count];
                index = 0;
                for (int i = 0; i < staffs.Count; i++)
                    staffName[i] = staffs[i].lastName + "," + staffs[i].firstName;
                staffcomboBox.DataSource = staffName;

                staffcomboBox.SelectedItem = staffName[index];
                isbinding = true;
            }
            else
            {
                Addbtn.Enabled = false;
                Updatebtn.Enabled = true;
                assettextBox.Text = it.asset;
                campusCodetextBox.Text = it.campusCode.ToString();
                bldgtextBox.Text = it.bldg;
                roomtextBox.Text = it.room;
                dateTimePicker.Value = it.acqDate;
                costtextBox.Text = it.totalCost.ToString();
                descriptiontextBox.Text = it.description;
                modeltextBox.Text = it.Model;
                otherLocationtextBox.Text = it.otherLocation;
                serialNumbertextBox.Text = it.serialNumber;
                Staff staff = it.Staffs;

                commentstextBox.Text = it.comments;
                IList<Staff> staffs = repo.Query<Staff>();
                staffName = new string[staffs.Count];
                index = 0;
                for (int i = 0; i < staffs.Count; i++)
                {
                    staffName[i] = staffs[i].lastName + "," + staffs[i].firstName;
                    if (staffs[i].firstName == it.Staffs.firstName && staffs[i].lastName == it.Staffs.lastName)
                        index = i;
                }
                staffcomboBox.DataSource = staffName;

                staffcomboBox.SelectedItem = staffName[index];
                isbinding = true;
                //staffcomboBox.ValueMember = it.Staffs.firstName + "," + it.Staffs.lastName;


            }
        }

        public static bool validateInteger(string str)
        {
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
                if (ch[i] > '9' || ch[i] < '0')
                    return false;
            return true;
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            //NHibernateRepository repo = new NHibernateRepository();
            Item item = new Item();
            string staffName = staffcomboBox.SelectedItem.ToString();
            {
                char[] ch = new char[staffName.Length];
                ch = staffName.ToCharArray();
                int i;
                for (i = 0; i < staffName.Length; i++)
                    if (ch[i] == ',')
                        break;
                string lastName = staffName.Substring(0, i);
                string firstName = staffName.Substring(i + 1, staffName.Length - i - 1);
                ICriterion[] expressions = new ICriterion[2];
                expressions[0] = Expression.Eq("firstName", firstName);
                expressions[1] = Expression.Eq("lastName", lastName);

                IList<Staff> st = repo.Query<Staff>(expressions);
                item.Staffs = st[0];
            }

            if (assettextBox.Text != "" && bldgtextBox.Text != "" && campusCodetextBox.Text != "" && roomtextBox.Text != "" && costtextBox.Text != "" && descriptiontextBox.Text != "" && validateInteger(campusCodetextBox.Text))
            {
                item.asset = assettextBox.Text;
                item.bldg = bldgtextBox.Text;
                item.campusCode = Convert.ToInt32(campusCodetextBox.Text);
                item.room = roomtextBox.Text;
                decimal cost;
                if (Decimal.TryParse(costtextBox.Text, out cost))
                    item.totalCost = cost;
                else
                {
                    MessageBox.Show("Please check your totalCost blank!");
                    return;
                }
                item.description = descriptiontextBox.Text;

            }
            else
            {
                MessageBox.Show("Please check what you entered!");
                return;
            }
            item.acqDate = dateTimePicker.Value;
            if (modeltextBox.Text != "")
                item.Model = modeltextBox.Text;
            if (otherLocationtextBox.Text != "")
                item.otherLocation = otherLocationtextBox.Text;
            if (serialNumbertextBox.Text != "")
                item.serialNumber = serialNumbertextBox.Text;
            if (commentstextBox.Text != "")
                item.comments = commentstextBox.Text;

            if (pic != null)
                item.picture = pic;
            item.isDelete = false;
            repo.SaveOrUpdate(item);

            this.DialogResult = DialogResult.OK;
            this.Close();
            return;

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

            repo.SaveOrUpdate(it);
            this.DialogResult = DialogResult.OK;
            this.Close();
            return;


        }

        private void bldgtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.bldg = bldgtextBox.Text;
            }
        }

        private void assettextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                if (it.asset != assettextBox.Text)
                {
                    DialogResult result = MessageBox.Show(this, "Are you sure to update asset?", "Please confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                        IList<Item> items = repo.Query<Item>(Expression.Eq("asset", assettextBox.Text));
                        if (items.Count > 0)
                        {
                            MessageBox.Show("There exist the item with same asset you entered,please check it again!");
                            return;
                        }
                        else
                            it.asset = assettextBox.Text;
                    }
                }
            }
        }


        private void campusCodetextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                if (campusCodetextBox.Text != "")
                {
                    if (validateInteger(campusCodetextBox.Text))
                        it.campusCode = Convert.ToInt32(campusCodetextBox.Text);
                    else
                        MessageBox.Show("Please make sure that your new campusCode is right");
                }
            }
        }

        private void roomtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.room = roomtextBox.Text;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.acqDate = dateTimePicker.Value;
            }
        }

        private void costtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                if (costtextBox.Text != "")
                {
                    decimal cost;
                    if (Decimal.TryParse(costtextBox.Text, out cost))
                        it.totalCost = cost;
                    else
                    {
                        MessageBox.Show("Please check your totalCost blank!");
                        return;
                    }
                }
            }
        }

        private void descriptiontextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.description = descriptiontextBox.Text;
            }
        }

        private void modeltextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.Model = modeltextBox.Text;
            }
        }

        private void otherLocationtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.otherLocation = otherLocationtextBox.Text;
            }

        }

        private void serialNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.serialNumber = serialNumbertextBox.Text;
            }
        }

        private void commentstextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                it.comments = commentstextBox.Text;
            }
        }




        private void staffcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(staffcomboBox.SelectedItem.ToString());
            if (isbinding == true)
            {
                if (!isAddNew) //update
                {
                    string name = staffcomboBox.SelectedItem.ToString();
                    char[] ch = new char[name.Length];
                    ch = name.ToCharArray();
                    int i;
                    for (i = 0; i < name.Length; i++)
                        if (ch[i] == ',')
                            break;
                    string lastName = name.Substring(0, i);

                    string firstName = name.Substring(i + 1, name.Length - i - 1);
                    ICriterion[] expressions = new ICriterion[2];
                    expressions[0] = Expression.Eq("firstName", firstName);
                    expressions[1] = Expression.Eq("lastName", lastName);

                    IList<Staff> st = repo.Query<Staff>(expressions);
                    it.Staffs = st[0];
                }
            }
        }


        public Byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void addPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                picturetextBox.Text = FileName.ToString();
                pic = ImageToByteArray(Image.FromFile(FileName));
                if (!isAddNew)
                    it.picture = pic;

            }
        }
    }
}
