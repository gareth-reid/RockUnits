using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockUnit
{
    public class Exponential
    {
        public Exponential(double baseNumber, double power)
        {
            Base = baseNumber;
            Power = power;
        }
        public double Base { get; set; }
        public double Power { get; set; }
    }
}
