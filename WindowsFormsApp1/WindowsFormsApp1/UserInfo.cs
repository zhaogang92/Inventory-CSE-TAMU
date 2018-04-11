using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    /// <summary>
    /// 用户持久化类
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户标识
        /// </summary>
        public virtual int ID { set; get; }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public virtual string UserName { set; get; }
        /// <summary>
        /// 性别
        /// </summary>
        public virtual bool Gender { set; get; }
        /// <summary>
        /// 年龄
        /// </summary>
        public virtual int Age { set; get; }
        /// <summary>
        /// 住址
        /// </summary>
        public virtual string Address { set; get; }
    }
}
