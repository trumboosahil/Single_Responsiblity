using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    internal class Policy
    {
        public int PolicyId { get; set; }
        public int PolicyType { get; set; }
        public decimal MotorHomePrice { get; set; }
        public decimal WaterCraftPrice { get; set; }
    }
}
