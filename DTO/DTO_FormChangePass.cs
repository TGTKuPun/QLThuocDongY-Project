using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_FormChangePass
    {
        public string EMAIL { get; set; }

        public string PASSWORD { get; set; }

        public DTO_FormChangePass(string email, string password)
        {   
            this.EMAIL = email;
            this.PASSWORD = password;
        }
    }
}
