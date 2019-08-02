using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
    public class AdminService {

        private DAL.AdminDao adminDao = new DAL.AdminDao();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>是否成功</returns>
        public bool Login(string name,string password) {
            int? count = adminDao.Login(name,password);
            if(count != null && count > 0) {
                return true;
                }
            else {
                return false;
                }
            }
        }
    }
