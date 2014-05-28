using System;

namespace RockUnit.Unit.Time
{
    public class NanoSecond : Unit
    {
        public NanoSecond(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return String.Format("ns"); }
        }

        /// <summary>
        /// current value converted to seconds
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -9); ;
        }
    }
}