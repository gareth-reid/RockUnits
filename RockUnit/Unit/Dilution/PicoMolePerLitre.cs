using System;

namespace RockUnit.Unit.Dilution
{
    public class PicoMolePerLitre : Unit
    {
        public PicoMolePerLitre(float value = 0)
        {
            Value = value;
        }

        //e.g. Creatine clearance
        public override string UnitDescriber
        {
            get { return String.Format("pmol/L"); }
        }

        /// <summary>
        /// current value converted to molar (mole/L)
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -12);
        }
    }
}

