using System;

namespace RockUnit.Unit.Litre
{
    public class NanoLitre : Unit
    {
        public NanoLitre(float value = 0)
        {
            Value = value;
        }

        public override string UnitDescriber
        {
            get { return String.Format("nL"); }
        }

        /// <summary>
        /// current value converted to litres
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -9);
        }
    }
}