using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class TestModel
    {
        
       public live live { get; set; }
       public List<result> result { get; set; }
    }
    public class live
    {
        public string set { get; set; }
        public string value { get; set; }
        public string time { get; set; }
        public string twod { get; set; }
    }
    public class result
    {
        public string set { get; set; }
        public string value { get; set; }
        public string open_time { get; set; }
        public string twod { get; set; }
    }
}
