using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DAL {
    public class AdminDao {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>查询数据个数</returns>
        public int? Login(string name,string password) {
            string sql = "select count(1) from admin where name=@name and password=@password";
            MySqlParameter[] mySqlParameter = new MySqlParameter[] {
                new MySqlParameter("@name",name),
                new MySqlParameter("@password",password)
                     };
            return DAL.SqlHelper.ExecuteScalar(sql,mySqlParameter);


            }




        }
    }
