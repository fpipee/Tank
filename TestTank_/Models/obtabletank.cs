using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestTank_.Models
{
    public class obtabletank
    {
        public int id { get; set; }
        public int tankCapacity { get; set; }
        public int tankCapacityMax { get; set; }
        public int tankCapacityMin { get; set; }
        public int liquidCapacity { get; set; }
        public int liquidCapacityMin { get; set; }
        public int liquidCapacityMax { get; set; }
    }
}