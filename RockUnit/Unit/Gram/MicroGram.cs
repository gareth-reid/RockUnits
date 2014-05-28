using System;

namespace RockUnit.Unit.Gram
{
    public class MilliGram : Unit
    {
        public MilliGram(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return String.Format("mg"); }
        }

        /// <summary>
        /// current value converted to Gram
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value / 1000;
        }
    }
}