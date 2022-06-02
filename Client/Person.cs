using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Person
    {
        private string password;
        private string nickname;
        private string login;

        public Person(string password, string nickname, string login)
        {
            this.password = password;
            this.nickname = nickname;
            this.login = login;
        }

        public Person()
        {
            password = "";
            login = "";
            nickname = "";
        }

        public string getPassword() { return password; }
        public string getNickname() { return nickname; }
        public string getLogin() { return login; }

        public void setPasswrod(string password) { this.password = password; }
        public void setNickname(string nickname) { this.nickname = nickname; }
        public void setLogin(string login) { this.login = login; }

        public string toString()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.Append("Login : ");
            stringbuilder.Append(login);
            stringbuilder.Append("  Nickname : ");
            stringbuilder.Append(nickname);
            return stringbuilder.ToString();

        }


    }
}
