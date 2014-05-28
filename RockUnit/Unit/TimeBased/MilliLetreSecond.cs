using System;

namespace RockUnit.Unit.TimeBased
{
    public class MilliLetreSecond : Unit
    {
        public MilliLetreSecond(float value = 0)
        {
            Value = value;
        }

        //e.g. Creatine clearance
        public override string ShortUnit
        {
            get { return String.Format("mL/s"); }
        }

        /// <summary>
        /// current value converted to  ML per second
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value;
        }
    }
}