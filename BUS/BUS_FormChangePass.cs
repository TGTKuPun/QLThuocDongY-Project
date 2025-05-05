using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_FormChangePass
    {
        DAL_FormChangePass dal_FormChangePass = new DAL_FormChangePass();

        public DTO_FormChangePass checkEmail(string email, string old_password, string new_password, out bool Identity)
        {
            Identity = false;
            DTO_FormChangePass emailInfo = dal_FormChangePass.getInfo(email);

            if (emailInfo != null)
            {
                if (Identity = emailInfo.PASSWORD.Equals(old_password))
                {
                    Identity = true;
                    return emailInfo;
                }
            }

            return null;
        }

        public void changePassword (string email, string new_password)
        {
            dal_FormChangePass.changePassword(email, new_password);
        }

    }
}
