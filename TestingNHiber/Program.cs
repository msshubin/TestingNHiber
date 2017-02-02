using NHibernate;

using System;
using TestingNHiber.Domain;

namespace TestingNHiber
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Add new account
/*            Console.Write("Enter login: ");
            string login = Console.ReadLine();

            Console.Write("Enter your fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("Enter password: ");
            string plainpassword = Console.ReadLine();

            string password = SecurePasswordHasher.Hash(plainpassword);

            // Создаем экземпляр класса User
            User user = new User(login, fullname, password);
*/
            #endregion

            // Иницивализация домена
            Dom.Init();

            // достаем сессию
            ISession session = Dom.CurrentSession;

            // Начинаем явную транзакцию
            ITransaction tr = session.BeginTransaction();

            // Сохрананяем объект в сессии
            //session.Save(user);

            // Завершаем транзакцию. Сейчас данные будут физически записаны в БД
            // После этого можно отрыть таблицу в БД и убедиться, что там действительно появилаь новая запись
            //            tr.Commit();
            //            session.Flush();

            // Очищаем кэш сессии, чтобы быть уверенными, что объект будет получен из базы, а не из сессии
            //            session.Clear();

            //ShowAllUsers(session);

            #region Теперь вытащим определенную запись из таблицы и обновим ее
            /*
            tr = session.BeginTransaction();
            Console.WriteLine("There are user with id 3: ");
            var oneuser = session.Get<User>(2);
            Console.WriteLine(oneuser.ID + " " + oneuser.LOGIN + " " + oneuser.FULLNAME + " " + oneuser.PASSWORD);
            Console.WriteLine("Add to end of fullname of {0} some characters ' - best user': ", oneuser.LOGIN);
            oneuser.FULLNAME += " - best user";
            oneuser.LEVEL = User.UserLevel.Senior;
            session.Update(oneuser);
            // session.Delete(oneuser); // if we need to delete founded record

            tr.Commit();
            */
            #endregion

            AddDocument(session, "Новый документ 1", DateTime.Now, "документ1.doc", 1);
            AddDocument(session, "Новый документ 2", DateTime.Now, "документ2.doc", 2);
            AddDocument(session, "Новый документ 3", DateTime.Now, "документ3.doc", 3);

            // Завершаем работу с базой.
            tr.Commit();
            session.Clear();
            Dom.Close();

            
            //Console.ReadKey();
        }

        static void ShowAllUsers(ISession session)
        {
            Console.WriteLine("There are all users in the base: ");
            var allusers = session.QueryOver<User>();
            foreach (var usr in allusers.List())
            {
                //Console.WriteLine(usr.ID + " " + usr.LOGIN + " " + usr.FULLNAME + " " + usr.PASSWORD + " " + usr.LEVEL);
                Console.WriteLine("{0} \t{1} \t {2} \t {3}",
                    usr.ID,
                    usr.LOGIN,
                    usr.FULLNAME,
                    usr.LEVEL);
            }
        }

        static void AddDocument(ISession session, string Name, DateTime CreationDate, string FileName, int UsersId)
        {
            IQuery query = session.CreateSQLQuery("exec AddDocument :Name, :CreationDate, :FileName, :UsersId");
            query.SetParameter("Name", Name);
            query.SetParameter("CreationDate", CreationDate);
            query.SetParameter("FileName", FileName);
            query.SetParameter("UsersId", UsersId);
            object obj = query.UniqueResult();

        }

    }
}
