using System;
using System.Collections.Generic;
using System.Text;

namespace MNSX.Model
{
    //博客表
    public class Blog
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int VisitNum { get; set; }
        public string CaBh { get; set; }
        public string CaName { get; set; }
        public string Remark { get; set; }
        public int Sort { get; set; }
    }
}
