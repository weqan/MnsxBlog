using System;
using System.Collections.Generic;
using System.Text;

namespace MNSX.Model
{
    //标签表
    public class Category
    {
        public int ID { get; set; }
        public string CaName { get; set; }
        public int bh { get; set; }
        public int Pbh { get; set; }
        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }

    }
}
