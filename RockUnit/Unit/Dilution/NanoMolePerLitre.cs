using System;

namespace RockUnit.Unit.Dilution
{
    public class NanoMolePerLitre : Unit
    {
        public NanoMolePerLitre(float value = 0)
        {
            Value = value;
        }

        //e.g. Creatine clearance
        public override string ShortUnit
        {
            get { return String.Format("nmol/L"); }
        }

        /// <summary>
        /// current value converted to molar (mole/L)
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -9);
        }
    }
}

