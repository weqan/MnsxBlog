using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using MNSX.Model;

namespace MNSX.DAL
{
    public class AdminDAL
    {
        /// <summary>
        /// INSERT
        /// </summary>
        /// <returns></returns>
        public int Insert(Admin bo)
        {
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                int resid = connection.Query<int>(@"INSERT INTO Admin(AID, APwd, Remark, Sort) values(@AID,@APwd,@Remark,@Sort);SELECT @@IDENTITY;", bo).FirstOrDefault();
                return resid;
            }
        }



    }
}
