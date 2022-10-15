using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnoverApp.Logic
{
    public class AuthorizationLog
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public AuthorizationLog(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public bool ComeIn(ref User user)
        {

        }
        public User GerObj()
        {
            
        }
    }
}
