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

        public int Unit()
        {
            return Convert.ToInt32(LuckyNumber.Substring(4));
        }                                                    
        public int Tens()
        {
            return Convert.ToInt32(LuckyNumber.Substring(3,1));
        }                                                    
        public int Hundreded()
        {
            return Convert.ToInt32(LuckyNumber.Substring(2,1));
        }                                                    
        public int Thousand()
        {
            return Convert.ToInt32(LuckyNumber.Substring(1,1));
        }                                                    
        public int TenThousand()
        {
            return Convert.ToInt32(LuckyNumber.Substring(0,1));
        }
    }

    public class LuckyEnlottery
    {
        public List<LuckyMan> LuckyMen { get; set; }
    }
}
