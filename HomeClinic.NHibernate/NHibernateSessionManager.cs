using Microsoft.Practices.Unity.InterceptionExtension;
using NHibernate;
using NHibernate.Context;
using System;
using System.Collections.Generic;

namespace HomeClinic.NHibernate
{
    public class NHibernateSessionManager : IInterceptionBehavior
    {
        private static readonly object _lockObject = new object();

        ISessionFactory _sessionfactory;

        Boolean isOpenedSession;

        public NHibernateSessionManager(ISessionFactory sessionfactory)
        {
            _sessionfactory = sessionfactory;

            isOpenedSession = false;
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            lock (_lockObject)
            {
                ISession session = null;

                if (!isOpenedSession)
                {
                    session = _sessionfactory.OpenSession();

                    CurrentSessionContext.Bind(session);

                    session.BeginTransaction();

                    isOpenedSession = true;
                }

                try
                {
                    var methodResult = getNext().Invoke(input, getNext);

                    if (session != null) session.Transaction.Commit();

                    return methodResult;
                }
                catch (Exception exc)
                {
                    if (session != null) session.Transaction.Rollback();

                    throw exc;
                }
                finally
                {
                    if (session != null)
                    {
                        CurrentSessionContext.Unbind(session.SessionFactory);

                        session.Transaction.Dispose();

                        session.Dispose();

                        isOpenedSession = false;
                    }
                }
            }
        }

        public Boolean WillExecute { get { return true; } }
    }
}
