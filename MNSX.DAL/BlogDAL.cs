using Dapper;
using MNSX.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MNSX.DAL
{
    public class BlogDAL
    {
        /// <summary>
        /// INSERT
        /// </summary>
        /// <returns></returns>
        public int Insert(Blog bo)
        {
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                int resid = connection.Query<int>(@"INSERT INTO Blog(Title,Body,VisitNum,CaBh,CaName,Remark,Sort) values(@Title,@Body,@VisitNum,@CaBh,@CaName,@Remark,@Sort);SELECT @@IDENTITY;", bo).FirstOrDefault();
                return resid;
            }
        }


        /// <summary>
        /// GET LIST
        /// </summary>
        /// <param name="cond"></param>
        /// <returns></returns>
        public List<Blog> GetList(string cond)
        {
            using (var connection = ConnectionFactory.GetOpenConnection())
            {
                string sql = "SELECT * FROM Blog";
                if (!string.IsNullOrEmpty(cond))
                {
                    sql += $" WHERE {cond}";
                }

                var list = connection.Query<Blog>(sql).ToList();
                return list;
            }
        }


    }
}
