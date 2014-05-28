using System;

namespace RockUnit.Unit.Metre
{
    public class CentreMetre : Unit
    {
        public CentreMetre(float value = 0)
        {
            Value = value;
        }
        public override string ShortUnit
        {
            get { return String.Format("cm"); }
        }

        /// <summary>
        /// current value converted to metre
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value / 100; 
        }
    }
}