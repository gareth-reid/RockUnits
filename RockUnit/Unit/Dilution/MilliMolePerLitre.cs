using System;

namespace RockUnit.Unit.Dilution
{
    public class MilliMolePerLitre : Unit
    {
        public MilliMolePerLitre(float value = 0)
        {
            Value = value;
        }

        //e.g. Creatine clearance
        public override string UnitDescriber
        {
            get { return String.Format("mmol/L"); }
        }

        /// <summary>
        /// current value converted to mmol per litre
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -3);
        }
    }
}