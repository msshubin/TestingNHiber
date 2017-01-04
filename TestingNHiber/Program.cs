using NHibernate;

using System;
using TestingNHiber.Domain;

namespace TestingNHiber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add new account
            Console.Write("Enter login: ");
            string login = Console.ReadLine();

            Console.Write("Enter your fullname: ");
            string fullname = Console.ReadLine();

            Console.Write("Enter password: ");
            string plainpassword = Console.ReadLine();

            string password = SecurePasswordHasher.Hash(plainpassword);

            // Создаем экземпляр класса User
            User user = new User(login, fullname, password);

            // Иницивализация домена
            Dom.Init();

            // достаем сессию
            ISession session = Dom.CurrentSession;

            // Начинаем явную транзакцию
            ITransaction tr = session.BeginTransaction();

            // Сохрананяем объект в сессии
            session.Save(user);

            // Завершаем транзакцию. Сейчас данные будут физически записаны в БД
            // После этого можно отрыть таблицу в БД и убедиться, что там действительно появилаь новая запись
            tr.Commit();
            session.Flush();

            // Очищаем кэш сессии, чтобы быть уверенными, что объект будет получен из базы, а не из сессии
            session.Clear();

            Console.WriteLine("There are all users in the base: ");
            var allusers = session.QueryOver<User>();
            foreach (var usr in allusers.List())
            {
                Console.WriteLine(usr.ID + " " + usr.LOGIN + " " + usr.FULLNAME + " " + usr.PASSWORD);
            }

            // Теперь вытащим определенную запись из таблицы и обновим ее
            tr = session.BeginTransaction();
            Console.WriteLine("There are user with id 3: ");
            var oneuser = session.Get<User>(3);
            Console.WriteLine(oneuser.ID + " " + oneuser.LOGIN + " " + oneuser.FULLNAME + " " + oneuser.PASSWORD);
            Console.WriteLine("Add to end of fullname of {0} some characters ' - best user': ", oneuser.LOGIN);
            oneuser.FULLNAME += " - best user";
            session.Update(oneuser);

            tr.Commit();



            // Завершаем работу с базой.
            session.Clear();
            Dom.Close();

            Console.ReadKey();
        }
    }
}
