using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_FormChangePass
    {
        public DTO_FormChangePass getInfo(string email)
        {

            string sql = $"SELECT email, Passs FROM tb_useraccount WHERE email = '{email}'";

            DataTable dt = Connection.selectQuery(sql);

            if (dt.Rows.Count > 0)
            {
                return new DTO_FormChangePass(
                    dt.Rows[0]["email"].ToString().Trim(), /*assign data to variable 'email'*/
                    dt.Rows[0]["Pass"].ToString().Trim() /*assign data to variable 'password'*/
                );
            }
            else return null;
        }

        public void changePassword (string email, string new_password)
        {
            string sql = $"UPDATE tb_useraccount SET Pass = '{new_password}' WHERE email = '{email}' ";

            Connection.actionQuery(sql);
        }
    }
}
