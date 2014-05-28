using System;

namespace RockUnit.Unit.Time
{
    public class PicoSecond : Unit
    {
        public PicoSecond(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return String.Format("ps"); }
        }

        /// <summary>
        /// current value converted to seconds
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -12); ;
        }
    }
}