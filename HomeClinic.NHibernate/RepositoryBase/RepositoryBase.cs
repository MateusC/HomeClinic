using HomeClinic.NHibernate.Interface;
using NHibernate;
using NHibernate.Linq;
using System.Linq;

namespace HomeClinic.NHibernate.RepositoryBase
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
    {
        protected ISession CurrentSession { get { return NHibernateContext.CurrentContext.CurrentSession(); } }

        public RepositoryBase() { }

        public virtual void Delete(T component)
        {
            CurrentSession.Delete(component);
        }

        public virtual IQueryable<T> GetAll()
        {
            return CurrentSession.Query<T>();
        }

        public virtual T Insert(T component)
        {
            CurrentSession.Save(component);

            return component;
        }

        public virtual T Update(T component)
        {
            CurrentSession.Update(component);

            return component;
        }
    }
}
