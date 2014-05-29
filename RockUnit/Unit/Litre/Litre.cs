using System;

namespace RockUnit.Unit.Litre
{
    public class Litre : Unit
    {
        public Litre(float value = 0)
        {
            Value = value;
        }

        public override string UnitDescriber
        {
            get { return String.Format("L"); }
        }

        /// <summary>
        /// current value converted to litres
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value;
        }
    }
}