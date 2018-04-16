using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Criterion;

namespace InventoryApp.Common
{
    public class NHibernateRepository : IRepository
    {
        private ISession session;

        public NHibernateRepository()
        {
            this.session = NHibernateHelper.GetCurrentSession();
        }

        public IList<T> Query<T>() where T : class
        {
            return session.CreateCriteria<T>().List<T>();
        }

        public IList<T> Query<T>(Action<NHibernate.ICriteria> action) where T : class
        {
            ICriteria criteria = session.CreateCriteria<T>();
            action(criteria);
            return criteria.List<T>();
        }

        public IList<T> Query<T>(NHibernate.Criterion.ICriterion expression) where T : class
        {
            return Query<T>(expression, null);
        }

        public IList<T> Query<T>(ICriterion[] expresions) where T : class
        {
            return Query<T>(expresions, null);
        }

        public IList<T> Query<T>(NHibernate.Criterion.ICriterion expression, Action<NHibernate.ICriteria> action) where T : class
        {
            return Query<T>(new ICriterion[] { expression }, action);
        }



        public IList<T> Query<T>(ICriterion[] expressions, Action<ICriteria> action) where T : class
        {
            ICriteria criteria = session.CreateCriteria<T>();
            if (expressions != null)
            {
                foreach (var expression in expressions)
                {
                    criteria.Add(expression);
                }
            }
            if (action != null)
            {
                action(criteria);
            }
            return criteria.List<T>();
        }

        public IList<T> Query<T>(string hql) where T : class
        {
            return session.CreateQuery(hql).List<T>();
        }

        public IList<T> Query<T>(string hql, object[] values) where T : class
        {
            IQuery query = session.CreateQuery(hql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(i, values[i]);
            }
            return query.List<T>();
        }

        public IList<T> Query<T>(string hql, string name, object value) where T : class
        {
            IQuery query = session.CreateQuery(hql);
            query.SetParameter(name, value);
            return query.List<T>();
        }

        public IList<T> Query<T>(string hql, string[] names, object[] values) where T : class
        {
            if (names.Length != values.Length)
                throw new QueryParameterException("查询参数不匹配！");
            IQuery query = session.CreateQuery(hql);
            for (int i = 0; i < names.Length; i++)
            {
                query.SetParameter(names[i], values[i]);
            }
            return query.List<T>();
        }

        public IList<T> Query<T>(string hql, Action<IQuery> action) where T : class
        {
            IQuery query = session.CreateQuery(hql);
            if (action != null)
                action(query);
            return query.List<T>();
        }

        public T Load<T>(object id) where T : class
        {
            return session.Load<T>(id);
        }

        public T Get<T>(object id) where T : class
        {
            return session.Get<T>(id);
        }

        public object Insert(object model)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    object id = session.Save(model);
                    transaction.Commit();
                    return id;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
        

        public void Update(object model)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Update(model);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void Save(object model)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Save(model);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void Update(string hql, string[] names, object[] values)
        {
            if (names.Length != values.Length)
                throw new ArgumentException("参数不匹配！");
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    IQuery query = session.CreateQuery(hql);
                    for (var i = 0; i < names.Length; i++)
                    {
                        query.SetParameter(names[i], values[i]);
                    }
                    var rs = query.ExecuteUpdate();
                    if (rs > 0)
                        transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void SaveOrUpdate(object model)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.SaveOrUpdate(model);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void SaveOrUpdate(object model1,object model2)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.SaveOrUpdate(model1);
                    session.SaveOrUpdate(model2);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public T Merge<T>(T model) where T : class
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    T t = session.Merge<T>(model);
                    transaction.Commit();
                    return t;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void Merge(object model)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Merge(model);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void Delete(object model)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Delete(model);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void DeleteByQuery(string hql)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    session.Delete(hql);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void DeleteByQuery(string hql, string name, object value)
        {
            DeleteByQuery(hql, new string[] { name }, new object[] { value });
        }

        public void DeleteByQuery(string hql, string[] names, object[] values)
        {
            if (names.Length != values.Length)
                throw new QueryParameterException("查询参数不匹配！");
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    IQuery query = session.CreateQuery(hql);
                    for (int i = 0; i < names.Length; i++)
                    {
                        query.SetParameter(names[i], values[i]);
                    }
                    query.ExecuteUpdate();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public void DeleteByQuery(string hql, object[] values)
        {
            using (ITransaction transaction = session.BeginTransaction())
            {
                try
                {
                    IQuery query = session.CreateQuery(hql);
                    for (int i = 0; i < values.Length; i++)
                    {
                        query.SetParameter(i, values[i]);
                    }
                    query.ExecuteUpdate();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }

        public int GetCount<T>() where T : class
        {
            return session.CreateCriteria<T>().SetProjection(Projections.RowCount()).UniqueResult<int>();
        }

        public int GetCount<T>(NHibernate.Criterion.ICriterion expression) where T : class
        {
            ICriteria criteria = session.CreateCriteria<T>();
            if (expression != null)
            {
                criteria.Add(expression);
            }
            return criteria.SetProjection(Projections.RowCount()).UniqueResult<int>();
        }

        public object ExcuteScalar(string hql)
        {
            return session.CreateQuery(hql).UniqueResult();
        }

        public object ExcuteScalar(string hql, object[] values)
        {
            IQuery query = session.CreateQuery(hql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(i, values[i]);
            }
            return query.UniqueResult();
        }

        public object ExcuteScalar(string hql, string name, object value)
        {
            return ExcuteScalar(hql, new string[] { name }, new object[] { value });
        }

        public object ExcuteScalar(string hql, string[] names, object[] values)
        {
            if (names.Length != values.Length)
                throw new QueryParameterException("查询参数不匹配！");
            IQuery query = session.CreateQuery(hql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(names[i], values[i]);
            }
            return query.UniqueResult();
        }

        public object ExcuteScalar(string hql, Action<NHibernate.IQuery> action)
        {
            IQuery query = session.CreateQuery(hql);
            if (action != null)
                action(query);
            return query.UniqueResult();
        }

        public object ExcuteScalarBySQL(string sql)
        {
            return session.CreateSQLQuery(sql).UniqueResult();
        }

        public object ExcuteScalarBySQL(string sql, object[] values)
        {
            ISQLQuery query = session.CreateSQLQuery(sql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(i, values[i]);
            }
            return query.UniqueResult();
        }

        public object ExcuteScalarBySQL(string sql, string name, object value)
        {
            return ExcuteScalarBySQL(sql, new string[] { name }, new object[] { value });
        }

        public object ExcuteScalarBySQL(string sql, string[] names, object[] values)
        {
            if (names.Length != values.Length)
                throw new QueryParameterException("查询参数不匹配！");
            ISQLQuery query = session.CreateSQLQuery(sql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(names[i], values[i]);
            }
            return query.UniqueResult();
        }

        public object ExcuteScalarBySQL(string sql, Action<ISQLQuery> action)
        {
            ISQLQuery query = session.CreateSQLQuery(sql);
            if (action != null)
                action(query);
            return query.UniqueResult();
        }

        public IList<T> QueryPaging<T>(NHibernate.Criterion.ICriterion expression,
            NHibernate.Criterion.Order[] orders, int pageIndex, int pageSize,
            out int recordCount) where T : class
        {
            recordCount = 0;
            ICriteria criteria = session.CreateCriteria<T>();
            if (expression != null)
            {
                criteria.Add(expression);
            }
            ICriteria pageCriteria = CriteriaTransformer.Clone(criteria);
            recordCount = criteria.SetProjection(Projections.RowCount()).UniqueResult<int>();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    pageCriteria.AddOrder(order);
                }
            }
            pageCriteria.SetFirstResult((pageIndex - 1) * pageSize);
            pageCriteria.SetMaxResults(pageSize);
            return pageCriteria.List<T>();
        }

        public IList<T> QueryPaging<T>(ICriterion expression, Order order, int pageIndex, int pageSize, out int recordCount) where T : class
        {
            return QueryPaging<T>(expression, new Order[] { order }, pageIndex, pageSize, out recordCount);
        }

        public IList<T> QueryPaging<T>(NHibernate.Criterion.ICriterion expression, int pageIndex, int pageSize, out int recordCount) where T : class
        {
            return QueryPaging<T>(expression, new Order[] { }, pageIndex, pageSize, out recordCount);
        }

        public IList<T> QueryPaging<T>(int pageIndex, int pageSize, out int recordCount) where T : class
        {
            return QueryPaging<T>(null, new Order[] { }, pageIndex, pageSize, out recordCount);
        }

        public IList<T> QueryPaging<T>(string hql, object[] values, int pageIndex, int pageSize) where T : class
        {
            IQuery query = session.CreateQuery(hql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(i, values[i]);
            }
            query.SetFirstResult((pageIndex - 1) * pageSize);
            query.SetMaxResults(pageSize);
            return query.List<T>();
        }

        public IList<T> QueryPaging<T>(string hql, string name, object value, int pageIndex, int pageSize) where T : class
        {
            return QueryPaging<T>(hql, new string[] { name }, new object[] { value }, pageIndex, pageSize);
        }

        public IList<T> QueryPaging<T>(string hql, string[] names, object[] values, int pageIndex, int pageSize) where T : class
        {
            if (names.Length != values.Length)
                throw new QueryParameterException("查询参数不匹配！");
            IQuery query = session.CreateQuery(hql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(names[i], values[i]);
            }
            query.SetFirstResult((pageIndex - 1) * pageSize);
            query.SetMaxResults(pageSize);
            return query.List<T>();
        }

        public IList<T> QueryPaging<T>(string hql, int pageIndex, int pageSize)
        {
            IQuery query = session.CreateQuery(hql);
            query.SetFirstResult((pageIndex - 1) * pageSize);
            query.SetMaxResults(pageSize);
            return query.List<T>();
        }

        public System.Collections.IList QueryBySQL(string sql)
        {
            return session.CreateSQLQuery(sql).List();
        }

        public System.Collections.IList QueryBySQL(string sql, object[] values)
        {
            ISQLQuery query = session.CreateSQLQuery(sql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(i, values[i]);
            }
            return query.List();
        }

        public System.Collections.IList QueryBySQL(string sql, string name, object value)
        {
            return QueryBySQL(sql, new string[] { name }, new object[] { value });
        }

        public System.Collections.IList QueryBySQL(string sql, string[] names, object[] values)
        {
            if (names.Length != values.Length)
                throw new QueryParameterException("查询参数不匹配！");
            ISQLQuery query = session.CreateSQLQuery(sql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(names[i], values[i]);
            }
            return query.List();
        }

        public System.Collections.IList QueryBySQL(string sql, Action<NHibernate.ISQLQuery> action)
        {
            ISQLQuery query = session.CreateSQLQuery(sql);
            if (action != null)
                action(query);
            return query.List();
        }

        public System.Collections.IList QueryBySQL(string sql, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public System.Collections.IList QueryBySQL(string sql, object[] values, int pageIndex, int pageSize)
        {
            ISQLQuery query = session.CreateSQLQuery(sql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(i, values[i]);
            }
            query.SetFirstResult((pageIndex - 1) * pageSize);
            query.SetMaxResults(pageSize);
            return query.List();
        }

        public System.Collections.IList QueryBySQL(string sql, string name, object value, int pageIndex, int pageSize)
        {
            return QueryBySQL(sql, new string[] { name }, new object[] { value }, pageIndex, pageSize);
        }

        public System.Collections.IList QueryBySQL(string sql, string[] names, object[] values, int pageIndex, int pageSize)
        {
            if (names.Length != values.Length)
                throw new QueryParameterException("查询参数不匹配！");
            ISQLQuery query = session.CreateSQLQuery(sql);
            for (int i = 0; i < values.Length; i++)
            {
                query.SetParameter(names[i], values[i]);
            }
            query.SetFirstResult((pageIndex - 1) * pageSize);
            query.SetMaxResults(pageSize);
            return query.List();
        }
    }
}
