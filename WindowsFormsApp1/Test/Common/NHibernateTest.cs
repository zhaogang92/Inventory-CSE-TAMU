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
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=C:\Users\q_122\Dropbox\phd\Courses\SoftwareEngineering\Project\Inventory-CSE-TAMU\WindowsFormsApp1\WindowsFormsApp1\Data\database.db;Version=3;");
            m_dbConnection.Open();
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        [TestMethod]
        public void TestConnection()
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

            NHibernateRepository repo = new NHibernateRepository();
            //repo.DeleteByQuery("select * from Item;");
            repo.SaveOrUpdate(staff);
            Assert.AreEqual(repo.Query<Staff>().Count, 1);
        }
    }
}
