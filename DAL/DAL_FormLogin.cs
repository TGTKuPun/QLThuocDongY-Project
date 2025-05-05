using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_FormLogin
    {
        public DTO_FormLogin checkLogin(string username, string password)
        {
            string sql = $"SELECT RTRIM(id_user) AS id_user, username, RTRIM(Pass) AS Pass, RTRIM(email) AS email, user_role  FROM tb_useraccount WHERE username = '{username}' AND Pass = '{password}'";
            DataTable dt = Connection.selectQuery(sql);

            if (dt.Rows.Count > 0)
            {
                // Initialize a object to store the data from database
                return new DTO_FormLogin(
                    dt.Rows[0]["id_user"].ToString().Trim(),
                    dt.Rows[0]["username"].ToString().Trim(),
                    dt.Rows[0]["Pass"].ToString().Trim(),
                    dt.Rows[0]["email"].ToString().Trim(),
                    dt.Rows[0]["user_role"].ToString().Trim()
                );
            }
            return null;
        }
    }
}
