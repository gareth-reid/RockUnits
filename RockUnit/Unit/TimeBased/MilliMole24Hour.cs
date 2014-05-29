using System;

namespace RockUnit.Unit.TimeBased
{
    public class MilliMole24Hour : Unit
    {
        public MilliMole24Hour(float value = 0)
        {
            Value = value;
        }

        //e.g. Urine pottasium study
        public override string UnitDescriber
        {
            get { return String.Format("mmol/24h"); }
        }

        /// <summary>
        /// current value converted to mmol per second
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * 24 * 60 * 60;
        }
    }
}