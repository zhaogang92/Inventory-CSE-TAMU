using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryApp.Common;
using InventoryApp.Model;
using System.Data.SQLite;
using NHibernate.Criterion;

using CCWin;

namespace InventoryApp.View
{
    public partial class StaffView : CCWin.CCSkinMain
    {
        private bool isAddNew;
        private Staff st;
        NHibernateRepository repo = new NHibernateRepository();
        bool isLoad = false;
        
        public StaffView(bool IsAddNew, Staff staff)
        {
            InitializeComponent();
            isAddNew = IsAddNew;
            st = staff;
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            if (isAddNew)
            {
                AddBtn.Enabled = true;
                UpdateBtn.Enabled = false;
            }
            else
            {
                AddBtn.Enabled = false;
                UpdateBtn.Enabled = true;
                firstNametextBox.Text = st.firstName;
                lastNametextBox.Text = st.lastName;
                groupCodetextBox.Text = st.groupCode;
                emailtextBox.Text = st.email;
                phonetextBox.Text = st.phone;
                locationtextBox.Text = st.location;
                isLoad = true;
            }
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Staff newStaff = new Staff();
            if (firstNametextBox.Text != "" && lastNametextBox.Text != "" && groupCodetextBox.Text != "")
            {
                ICriterion criterion = Expression.Eq("groupCode", groupCodetextBox.Text);
                IList<Staff> testExistSameGroupCode = repo.Query<Staff>(criterion);
                if (testExistSameGroupCode.Count == 0)
                {
                    newStaff.firstName = firstNametextBox.Text;
                    newStaff.lastName = lastNametextBox.Text;
                    newStaff.groupCode = groupCodetextBox.Text;
                }
                else
                {
                    MessageBox.Show("this groupCode is used, you can't use this groupCode");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please check what you entered!");
                return;
            }
            //do we need to check format???????????
            if (phonetextBox.Text != "")
                newStaff.phone = phonetextBox.Text;
            if (emailtextBox.Text != "")
                newStaff.email = emailtextBox.Text;
            if (locationtextBox.Text != "")
                newStaff.location = locationtextBox.Text;

            repo.SaveOrUpdate(newStaff);
            this.DialogResult = DialogResult.OK;
            this.Close();
            return;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            repo.SaveOrUpdate(st);
            this.DialogResult = DialogResult.OK;
            this.Close();
            return;

        }

        private void firstNametextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                st.firstName = firstNametextBox.Text;
            }
        }

        private void lastNametextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew)
            {
                st.lastName = lastNametextBox.Text;
            }
        }

        private void groupCodetextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew && isLoad)
            {
                ICriterion criterion = Expression.Eq("groupCode", groupCodetextBox.Text);
                IList<Staff> testExistSameGroupCode = repo.Query<Staff>(criterion);
                if (testExistSameGroupCode.Count == 0)
                {
                    st.groupCode = groupCodetextBox.Text;
                }
                else
                {
                    MessageBox.Show("this groupCode is used, you can't use this groupCode");
                    return;
                }
                
            }
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
            if(!isAddNew)
            {
                st.email = emailtextBox.Text;
            }
        }

        private void phonetextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew && isLoad)
            {
                st.phone = phonetextBox.Text;
            }
        }

        private void locationtextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isAddNew && isLoad)
            {
                st.location = locationtextBox.Text;
            }
        }
    }
}
