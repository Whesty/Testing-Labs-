using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Services
{
    internal static class UserCreator
    {
        private static string _login = "123456789";
        private static string _password = "123456789";

        public static Model.User WithCredentialsFromProperty()
        {
            return new Model.User(_login, _password);
        }

        public static Model.User WithEmptyCredentials()
        {
            return new Model.User("", "");
        }
        public static Model.User WhithEmptyLogin()
        {
            return new Model.User("", _password);
        }
        public static Model.User WhithEmptyPassword()
        {
            return new Model.User(_login, "");
        }

    }
}
