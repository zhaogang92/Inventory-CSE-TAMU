using System;
using System.Collections.Generic;
using InventoryApp;
using InventoryApp.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class StaffTest
    {
        [TestMethod]
        public void TestCreateStaffs()
        {
            var staff = new Staff()
            {
                groupCode = "TestGroupCode",
                lastName = "Hello",
                firstName = "World",
                email = "Hello_world@gmail.com",
                phone = "979979979",
                location = "HRBB"
            };

            IList<Staff> staffs = new List<Staff>();
            staffs.Add(staff);
            staffs.Add(staff);

            Assert.IsTrue(DBHelper.getDBHelper().CreateRecords<Staff>(staffs));
        }

        [TestMethod]
        public void TestCreateItems()
        {
            throw new NotImplementedException();
        }
    }
}
