using System;

namespace RockUnit.Unit.Dilution
{
    public class GramPerLitre : Unit
    {

        public GramPerLitre(float value = 0)
        {
            Value = value;
        }
        //e.g. Creatine clearance
        public override string ShortUnit
        {
            get { return String.Format("g/L"); }
        }

        /// <summary>
        /// current value converted to molar (mole/L)
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value;
        }
    }
}