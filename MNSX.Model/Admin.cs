using System;
using System.Collections.Generic;
using System.Text;

namespace MNSX.Model
{
    //管理员表
    public class Admin
    {
        public int ID { get; set; }
        public string AID { get; set; }
        public string APwd { get; set; }
        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }
        public int Sort { get; set; }
    }
}
