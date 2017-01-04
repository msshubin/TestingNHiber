using System;

namespace TestingNHiber.Domain
{
    public class User
    {
        private int Id { get; set; }
        private string Login { get; set; }
        private string FullName { get; set; }
        private string Password { get; set; }

        public virtual int ID
        {
            get { return Id; }
            protected set { Id = value; }
        }

        public virtual string LOGIN
        {
            get { return Login; }
            set { Login = value; }
        }

        public virtual string FULLNAME
        {
            get { return FullName; }
            set { FullName = value; }
        }

        public virtual string PASSWORD
        {
            get { return Password; }
            set { Password = value; }
        }

        public User()
        {

        }

        public User(string setLogin, string setFullName, string setPassword)
        {
            Login = setLogin;
            FullName = setFullName;
            Password = setPassword;
        }


    }
}
