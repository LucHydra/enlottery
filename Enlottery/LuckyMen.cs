using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enlottery
{
    public class LuckyMan
    {
        public string Man { get; set; }
        public string LuckyNumber { get; set; }
        public bool? IsDuplicated { get; set; }
    }

    public class LuckyEnlottery
    {
        public List<LuckyMan> LuckyMen { get; set; }
    }
}
