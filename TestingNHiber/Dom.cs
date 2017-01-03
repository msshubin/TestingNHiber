using NHibernate;
using NHibernate.Cfg;
using System.Runtime.Remoting.Messaging;

namespace TestingNHiber
{
    public static class Dom
    {
        private const string sessionKey = "NHib.SessionKey";
        private static ISessionFactory sessionFactory;

        public static ISession CurrentSession
        {
            get
            {
                return GetSession(true);
            }
        }

        public static void Init()
        {
            sessionFactory = new Configuration().Configure("hibernate.cfg.xml").BuildSessionFactory();
        }

        public static void Close()
        {
            ISession currentSession = GetSession(false);

            if (currentSession != null)
            {
                currentSession.Close();
            }
        }

        private static ISession GetSession(bool getNewIfNotExists)
        {
            ISession currentSession;

            /*if (HttpContext.Current != null)
            {
                HttpContext context = HttpContext.Current;
                currentSession = context.Items[sessionKey] as ISession;

                if (currentSession == null && getNewIfNotExists)
                {
                    currentSession = sessionFactory.OpenSession();
                    context.Items[sessionKey] = currentSession;
                }
            }
            else
            {*/
                currentSession = CallContext.GetData(sessionKey) as ISession;

                if (currentSession == null && getNewIfNotExists)
                {
                    currentSession = sessionFactory.OpenSession();
                    CallContext.SetData(sessionKey, currentSession);
                }
            /*}*/
            currentSession = CallContext.GetData(sessionKey) as ISession;

                if (currentSession == null && getNewIfNotExists)
                {
                    currentSession = sessionFactory.OpenSession();
                    CallContext.SetData(sessionKey, currentSession);
                }

            return currentSession;
        }
    }
}
