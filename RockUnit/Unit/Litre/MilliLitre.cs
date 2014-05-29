using System;

namespace RockUnit.Unit.Litre
{
    public class MilliLitre : Unit
    {
        public MilliLitre(float value = 0)
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
            return Value / 1000;
        }
    }
}