using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_FormUser
    {
        private DAL_FormUser dal_user = new DAL_FormUser();

        public List<DTO_FormUser> getUser()
        {
            DataTable dt = dal_user.getUser();
            List<DTO_FormUser> userList = new List<DTO_FormUser>();

            foreach (DataRow row in dt.Rows)
            {
                DTO_FormUser user = new DTO_FormUser(
                    row["id_user"].ToString(),
                    row["username"].ToString(),
                    row["Pass"].ToString(),
                    row["email"].ToString(),
                    row["user_role"].ToString());
                userList.Add(user);
            }
            return userList;
        }

        public void addUser(DTO_FormUser user)
        {
            dal_user.addUser(user);
        }

        public string generateUserID()
        {
            return dal_user.generateUserID();
        }

        public void delUser(List<string> ids)
        {
            dal_user.delUser(ids);
        }

        public void updateUser(DTO_FormUser user)
        {
            dal_user.updateUser(user);
        }
    }
}
