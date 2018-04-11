using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;


using NHibernate;
using NHibernate.Cfg;

namespace InventoryApp.Common
{
    public static class NHibernateHelper
    {
        private const string sessionKey = "nhibernate.current_session";
        private static readonly ISessionFactory sessionFactory;
        private static ISession backup_session = null;

        static NHibernateHelper()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
        }

        public static ISession GetCurrentSession()
        {
            ISession session = null;
            ////若第一次调用GetCurrentSession之前未使用ICurrentSessionContext的Bind方法,则会抛出HibernateException异常
            try
            {
                session = sessionFactory.GetCurrentSession();
                //HttpContext context = HttpContext.Current;
                //session = context.Items[sessionKey] as ISession;
                if (session == null || !session.IsOpen)
                {
                    session = sessionFactory.OpenSession();
                    NHibernate.Context.CurrentSessionContext.Bind(session);
                }
            }
            //捕捉此异常并打开一个新的session
            catch (HibernateException ex)
            {
                if (session != null)
                    session.Close();
                session = sessionFactory.OpenSession();
                NHibernate.Context.CurrentSessionContext.Bind(session);
            }
            catch (NullReferenceException e)
            {
                backup_session = GetNewSession();
                return backup_session;
            }
            //session = sessionFactory.OpenSession();
            //try
            //{
            //    if (NHibernate.Context.CurrentSessionContext.HasBind(sessionFactory))
            //    {
            //        session = sessionFactory.GetCurrentSession();
            //    }
            //    else
            //    {
            //        session = sessionFactory.OpenSession();
            //        NHibernate.Context.CurrentSessionContext.Bind(session);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Debug.Write(ex.Message);
            //    throw;
            //}

            return session;
        }

        /// <summary>
        /// 新获取一个ISession
        /// 请注意，此方法是为了应对CurrentSessionContext无法获取当前Session时使用，如在Session_End函数中
        /// </summary>
        /// <returns>ISession</returns>
        private static ISession GetNewSession()
        {
            return sessionFactory.OpenSession();
        }

        public static void CloseBackupSession()
        {
            if (backup_session == null)
                return;
            if (backup_session.IsOpen)
                backup_session.Close();
        }

        public static void CloseCurrentSession()
        {
            //ISession session = GetCurrentSession();
            //if (session != null && session.IsOpen)
            //{
            //    session.Close();
            //}

            var session = NHibernate.Context.CurrentSessionContext.Unbind(sessionFactory);
            if (session != null && session.IsOpen)
            {
                session.Close();
            }

            //HttpContext context = HttpContext.Current;
            //var session = context.Items[sessionKey] as ISession;
            //if (session == null)
            //    return;
            //if (session.IsOpen)
            //{
            //    session.Close();
            //}
            //context.Items.Remove(sessionKey);
        }

        public static void CloseSessionFactory()
        {
            if (sessionFactory != null && !sessionFactory.IsClosed)
            {
                sessionFactory.Close();
            }
        }
    }
}
