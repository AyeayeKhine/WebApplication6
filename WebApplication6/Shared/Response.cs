using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Shared
{
    public class ResponseList<T>
    {
        
        public Object live { get; set; }
        public List<T> result { get; set; }
    }
}
