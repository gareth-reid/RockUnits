using System;

namespace RockUnit.Unit.Litre
{
    public class PicoLitre : Unit
    {
        public PicoLitre(float value = 0)
        {
            Value = value;
        }

        public override string UnitDescriber
        {
            get { return String.Format("pL"); }
        }

        /// <summary>
        /// current value converted to litres
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -12);
        }
    }
}