using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_FormLogin
    {   
        public string USERID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string ROLE { get; set; } // Admin or Customer

        public DTO_FormLogin(string userID, string username, string password, string email, string role)
        {   
            this.USERID = userID;
            this.USERNAME = username;
            this.PASSWORD = password;
            this.EMAIL = email;
            this.ROLE = role;
        }
    }
}
