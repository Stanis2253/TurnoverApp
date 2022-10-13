using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWpf
{
    internal class Authorizarion
    {
        private string Login;

        private string Password;

        /// <summary>
        /// Авторизация в систему
        /// </summary>
        /// <returns>Возращает объект пользователя. Null, если пользователь не найден</returns>
        public User ComeIn()
        {
            using (TradeEntities db = new TradeEntities(string login, string password))
            {

                var User = FoundObj();
                Password = password;
                Login = login;
                if (User.UserPassword == Password)
                {
                    return User;
                }
                return null;
            }
        }

        private User FoundObj()
        {
            using (TradeEntities db = new TradeEntities())
            {
                var user = db.User.FirstOrDefault(x => x.UserLogin == Login);
                return user;
            }
        }
    }
}
