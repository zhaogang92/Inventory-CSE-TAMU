using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Criterion;

namespace InventoryApp.Common
{
    public interface IRepository
    {
        #region CRUD

        /// <summary>
        /// 查询所有实体
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns>所有实体的集合</returns>
        IList<T> Query<T>() where T : class;

        /// <summary>
        /// 查询满足条件的实体集合
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="action">处理ICrietria的委托</param>
        /// <returns>满足条件的实体集合</returns>
        IList<T> Query<T>(Action<ICriteria> action) where T : class;

        /// <summary>
        /// 查询满足expression指定的条件的实体集合
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="expression">条件</param>
        /// <returns>满足条件的实体集合</returns>
        IList<T> Query<T>(ICriterion expression) where T : class;

        /// <summary>
        /// 查询满足expression指定的条件的实体集合
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="expresions">条件集合</param>
        /// <returns>满足条件的实体集合</returns>
        IList<T> Query<T>(ICriterion[] expresions) where T : class;

        /// <summary>
        /// 查询满足条件的实体集合
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="expression">条件</param>
        /// <param name="action">处理ICriteria的委托</param>
        /// <returns>满足条件的实体集合</returns>
        IList<T> Query<T>(ICriterion expression, Action<ICriteria> action) where T : class;

        /// <summary>
        /// 查询满足条件的实体集合
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="expressions">条件集合</param>
        /// <param name="action">ICriteria</param>
        /// <returns>满足条件的实体集合</returns>
        IList<T> Query<T>(ICriterion[] expressions, Action<ICriteria> action) where T : class;

        /// <summary>
        /// HQL查询实体集合
        /// </summary>
        /// <typeparam name="T">查询的实体类型</typeparam>
        /// <param name="hql">HQL语句</param>
        /// <returns>HQL查询得到的实体集合</returns>
        IList<T> Query<T>(string hql) where T : class;

        /// <summary>
        /// HQL查询实体集合
        /// 查询语句中的参数使用'?'占位符的形式
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="hql">HQL语句</param>
        /// <param name="values">对应HQL语句中?占位符的查询参数</param>
        /// <returns>满足条件的实体集合</returns>
        IList<T> Query<T>(string hql, object[] values) where T : class;
        IList<T> Query<T>(string hql, string name, object value) where T : class;
        IList<T> Query<T>(string hql, string[] names, object[] values) where T : class;
        IList<T> Query<T>(string hql, Action<IQuery> action) where T : class;
        /*IQueryable<T> QueryLinq<T>() where T : class;
        IQueryable<T> QueryLinq<T>(Action<ICriterion> action) where T : class;
        IQueryable<T> QueryLinq<T>(ICriterion expression) where T : class;
        IQueryable<T> QueryLinq<T>(ICriterion expression, Action<ICriteria> action) where T : class;
        IQueryable<T> QueryLinq<T>(string hql) where T : class;
        IQueryable<T> QueryLinq<T>(string hql, params object[] values) where T : class;
        IQueryable<T> QueryLinq<T>(string hql, string name, object value) where T : class;
        IQueryable<T> QueryLinq<T>(string hql, string[] names, object[] values) where T : class;
        IQueryable<T> QueryLinq<T>(string hql, Action<ICriteria> action) where T : class;*/
        T Load<T>(object id) where T : class;
        T Get<T>(object id) where T : class;
        object Insert(object model);
        void Update(object model);
        void Update(string hql, string[] names, object[] values);
        void SaveOrUpdate(object model);
        T Merge<T>(T model) where T : class;
        void Merge(object model);
        void Delete(object model);
        void DeleteByQuery(string hql);
        void DeleteByQuery(string hql, string name, object value);
        void DeleteByQuery(string hql, string[] names, object[] values);
        void DeleteByQuery(string hql, object[] values);
        #endregion

        #region CRUD By SQL


        #endregion

        #region Count
        int GetCount<T>() where T : class;
        int GetCount<T>(ICriterion expression) where T : class;
        #endregion

        #region Scalar
        object ExcuteScalar(string hql);
        object ExcuteScalar(string hql, object[] values);
        object ExcuteScalar(string hql, string name, object value);
        object ExcuteScalar(string hql, string[] names, object[] values);
        object ExcuteScalar(string hql, Action<IQuery> action);
        #endregion

        #region ScalarBySQL
        object ExcuteScalarBySQL(string sql);
        object ExcuteScalarBySQL(string sql, object[] values);
        object ExcuteScalarBySQL(string sql, string name, object value);
        object ExcuteScalarBySQL(string sql, string[] names, object[] values);
        object ExcuteScalarBySQL(string sql, Action<ISQLQuery> action);
        #endregion

        #region Paging Query
        IList<T> QueryPaging<T>(ICriterion expression, Order order, int pageIndex, int pageSize, out int recordCount) where T : class;
        IList<T> QueryPaging<T>(ICriterion expression, Order[] orders, int pageIndex, int pageSize, out int recordCount) where T : class;
        IList<T> QueryPaging<T>(ICriterion expression, int pageIndex, int pageSize, out int recordCount) where T : class;
        IList<T> QueryPaging<T>(int pageIndex, int pageSize, out int recordCount) where T : class;
        IList<T> QueryPaging<T>(string hql, object[] values, int pageIndex, int pageSize) where T : class;
        IList<T> QueryPaging<T>(string hql, string name, object value, int pageIndex, int pageSize) where T : class;
        IList<T> QueryPaging<T>(string hql, string[] names, object[] values, int pageIndex, int pageSize) where T : class;
        IList<T> QueryPaging<T>(string hql, int pageIndex, int pageSize);
        #endregion

        #region Query By SQL
        IList QueryBySQL(string sql);
        IList QueryBySQL(string sql, object[] values);
        IList QueryBySQL(string sql, string name, object value);
        IList QueryBySQL(string sql, string[] names, object[] values);
        IList QueryBySQL(string sql, Action<ISQLQuery> action);
        #endregion

        #region Paging Query By SQL
        IList QueryBySQL(string sql, int pageIndex, int pageSize);
        IList QueryBySQL(string sql, object[] values, int pageIndex, int pageSize);
        IList QueryBySQL(string sql, string name, object value, int pageIndex, int pageSize);
        IList QueryBySQL(string sql, string[] names, object[] values, int pageIndex, int pageSize);
        #endregion
    }
}
