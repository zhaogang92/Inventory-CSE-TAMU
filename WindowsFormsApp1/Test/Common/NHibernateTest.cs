﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using InventoryApp.Common;
using InventoryApp.Model;
using System.Data.SQLite;
using NHibernate.Criterion;

namespace Test
{
    /// <summary>
    /// NHibernateTest 的摘要说明
    /// </summary>
    [TestClass]
    public class NHibernateTest
    {
        public NHibernateTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestSqlite3()
        {
            Console.WriteLine(System.IO.Path.GetFullPath(@"../../../WindowsFormsApp1/Data/database.db"));
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=../../../WindowsFormsApp1/Data/database.db;Version=3;");
            m_dbConnection.Open();
            string sql2 = "create table lowscores (name varchar(20), score int)";
            string sql = "select * from staff";
            string sql1 = "create table staff(staffID int auto_increment primary key,groupCode char(8),lastName char(30),firstName char(30),email char(40),phone char(15),location char(50))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        [TestMethod]
        public void TestConnection()
        {
            var staff = new Staff()
            {
                groupCode = "GroupCode",
                lastName = "11Hello",
                firstName = "22World",
                email = "33Hello_world@tamu.com",
                phone = "979979979",
                location = "HRBBf"
            };
            
            NHibernateRepository repo = new NHibernateRepository();
            
            //repo.DeleteByQuery("from Staff s");
            repo.SaveOrUpdate(staff);
            Assert.AreEqual(repo.Query<Staff>().Count, 1);
        }

        [TestMethod]
        public void InsertStaffAndItem()
        {
            var staff1 = new Staff()
            {
                groupCode = "Codde",
                lastName = "22shi",
                firstName = "11wei",
                email = "11sw@gmail.com",
                phone = "119798989987",
                location = "1HRBB"
            };
            byte[] bytes = { 201, 209 };
            var item1 = new Item()
            {
                asset = "134410",
                campusCode = 78,
                description = "This is a good one",
                bldg = "02-00445",
                room = "312B",
                otherLocation = "otherlocation",
                acqDate = new DateTime(2008, 8, 29),
                totalCost = Convert.ToDecimal(330044.04),
                Model = "Model",
                serialNumber = "FFF00000422",
                groupCode = staff1.groupCode,
                lastName = staff1.lastName,
                firstName = staff1.firstName,
                isDelete = false,
                comments = "comments",
                picture = bytes,


            };
            var item2 = new Item()
            {
                asset = "3143",
                campusCode = 18,
                description = "This is a good one",
                bldg = "332-00445",
                room = "312B",
                otherLocation = "otherlocation",
                acqDate = new DateTime(2008, 8, 29),
                totalCost = Convert.ToDecimal(330044.04),
                Model = "Model",
                serialNumber = "FFF00000422",
                groupCode = staff1.groupCode,
                lastName = staff1.lastName,
                firstName = staff1.firstName,
                isDelete = false,
                comments = "comments",
                picture = bytes,


            };


            //staff1.Items = new HashSet<Item> { item1 };
            item1.Staffs = staff1;
            item2.Staffs = staff1;
            NHibernateRepository repo = new NHibernateRepository();

            //repo.DeleteByQuery("from Item a");
            //object id = repo.Insert(staff1);


            //repo.DeleteByQuery("from Staff s");
            //repo.DeleteByQuery("from Item t");
            repo.SaveOrUpdate(staff1);
            //IList<Staff> st = repo.Query<Staff>();
            //var tt  = st[0];
            repo.SaveOrUpdate(item2);

            //Restrictions.Like("Firstname", "YJing%")
            //InventoryApp.Common.NHibernateRepository.ICriterion criterion = new ICriterion();
            //NHibernate.Criterion.ICriterion expr
            //System.Collections.IList it = repo.QueryBySQL("select * from item,staff where staff.groupCode = item.groupCode ");
             IList<Staff> st = repo.Query<Staff>("from Staff a where a.groupCode = 'Codde' ");
            Assert.AreEqual(repo.Query<Staff>().Count, 1);
        }

        [TestMethod]
        public void InsertNewItem()
        {
            NHibernateRepository repo = new NHibernateRepository();
            int oldCount = repo.Query<Item>().Count;
            var item2 = new Item()
            {
                asset = "3143",
                campusCode = 8,
                description = "This is a good one",
                bldg = "332-00445",
                room = "312B",
                otherLocation = "otherlocation",
                acqDate = new DateTime(2008, 8, 29),
                totalCost = Convert.ToDecimal(330044.04),
                Model = "Model",
                serialNumber = "FFF00000422",
                isDelete = false,
                comments = "comments",
      
            };
            IList<Staff> st = repo.Query<Staff>();
            item2.Staffs = st[0];
            repo.SaveOrUpdate(item2);
           
            Assert.AreEqual(repo.Query<Item>().Count, oldCount+1);
        }

        [TestMethod]
        public void Update()
        {
            NHibernateRepository repo = new NHibernateRepository();
            IList<Staff> st = repo.Query<Staff>();
            st[0].groupCode = "1345655";
            repo.Update(st[0]);
            int id = st[0].staffID;
            
            
            Assert.AreEqual("13456", repo.Query<Staff>()[0].groupCode);

        }

        [TestMethod]
        public void QueryByCriteria()
        {
            NHibernateRepository repo = new NHibernateRepository();
            var staffs = repo.Query<Staff>(Expression.Eq("staffID", 54));
            Assert.AreEqual(1, staffs.Count);
        }

        [TestMethod]
        public void QueryUser()
        {
            var repo = new NHibernateRepository();
            var users = repo.Query<User>(Expression.Eq("Name", "admin"));
            Assert.AreEqual(0, users.Count);
            User u = new User() { Name = "admin", Password = "password" };
            repo.Save(u);
        }
    }
}

      
       
    
