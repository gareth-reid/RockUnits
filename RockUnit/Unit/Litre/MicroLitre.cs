using System;

namespace RockUnit.Unit.Litre
{
    public class MicroLitre : Unit
    {
        public MicroLitre(float value = 0)
        {
            Value = value;
        }

        public override string UnitDescriber
        {
            get { return String.Format("ML"); }
        }

        /// <summary>
        /// current value converted to litres
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -6);
        }
    }
}