using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate;
using InventoryApp.Common;
namespace InventoryApp
{
    /// <summary>
    /// 用户数据层操作
    /// </summary>
    public class UserInfoData
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public bool AddUserInfo(UserInfo userInfo)
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            //ISession session = NHibernateHelper.GetOcextSession();
            using (ITransaction trans = session.BeginTransaction())
            {
                try
                {
                    session.SaveOrUpdate(userInfo);
                    session.Flush();
                    trans.Commit();
                    return true;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    return false;
                    throw;
                }
            }
        }
    }
}
