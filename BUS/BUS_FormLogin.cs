using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BUS
{
    public class BUS_FormLogin
    {
        private DAL_FormLogin dal_FormLogin = new DAL_FormLogin();

        public DTO_FormLogin checkLogin(string username, string password, out bool isAdmin)
        {
            isAdmin = false; 
            DTO_FormLogin userInfo = dal_FormLogin.checkLogin(username, password);

            if (userInfo != null)
            {
                // Chekc whether the user is admin or not
                if (userInfo.ROLE.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    isAdmin = true;
                }
                return userInfo; // return object of userInfo
            }

            return null; // Error Login
        }
    }
}
