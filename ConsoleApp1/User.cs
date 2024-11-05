using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public abstract class User
    {
        private int _id;
        private string _login;
        private string _password;

        public int ID
        {
            get => _id;
            set
            {
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Логин должен быть больше 5 символов");
                }

                else _login = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Пароль должен быть больше 5 символов");
                }

                else _password = value;
            }
        }
    }
}