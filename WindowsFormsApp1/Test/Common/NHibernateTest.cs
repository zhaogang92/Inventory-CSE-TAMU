using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;



using InventoryApp.Common;
using InventoryApp.Model;
using System.Data.SQLite;

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
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=C:\Users\wei shi\Documents\GitHub\Inventory-CSE-TAMU\WindowsFormsApp1\WindowsFormsApp1\Data\database.db;Version=3;");
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
                groupCode = "TestGroupCode",
                lastName = "Hello123",
                firstName = "World",
                email = "Hello_world@gmail.com",
                phone = "979979979",
                location = "HRBB"
            };
            
            NHibernateRepository repo = new NHibernateRepository();
            
            repo.DeleteByQuery("from Staff s");
            repo.SaveOrUpdate(staff);
            Assert.AreEqual(repo.Query<Staff>().Count, 1);
        }

        [TestMethod]
        public void InsertNewItem()
        {
            var staff1 = new Staff()
            {
                groupCode = "221Codde",
                lastName = "11shi",
                firstName = "11wei",
                email = "11sw@gmail.com",
                phone = "119798989987",
                location = "1HRBB"
            };
            byte[] bytes = { 201, 209 };
            var item1 = new Item()
            {
                asset = 134410,
                campusCode = 28,
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
                asset = 3143,
                campusCode = 38,
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


            //staff1.Items = new HashSet<Item> { item1 };
            item1.Staffs = staff1;
            item2.Staffs = staff1;
            NHibernateRepository repo = new NHibernateRepository();

            //repo.DeleteByQuery("from Item a");
            //object id = repo.Insert(staff1);
            //repo.SaveOrUpdate(staff1);
            repo.SaveOrUpdate(item2);
            //Assert.AreEqual(repo.Query<Item>().Count, 1);
        }

    }
}

      
       
    
