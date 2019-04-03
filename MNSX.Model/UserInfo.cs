using System;
using System.Collections.Generic;
using System.Text;

namespace MNSX.Model
{
    //用户信息
    public class UserInfo
    {
        public int ID { get; set; }  
        public string UName { get; set; }  
        public string UPwd { get; set; }  
        public DateTime CreateDate { get; set; }  
        public DateTime LastLoginTime { get; set; }  
        public string Remark { get; set; }  
        public int Sort { get; set; }
    }
}
