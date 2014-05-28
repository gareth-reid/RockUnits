using System;

namespace RockUnit.Unit.Mole
{
    public class MilliMole : Unit
    {
        public MilliMole(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return String.Format("mmol"); }
        }

        /// <summary>
        /// current value converted to mole
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -3);
        }
    }
}