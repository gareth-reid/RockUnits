using System;

namespace RockUnit.Unit.Dilution
{
    public class MicroMolePerLitre : Unit
    {
        
        public MicroMolePerLitre(float value = 0)
        {
            Value = value;
        }
        //e.g. Creatine clearance
        public override string ShortUnit
        {
            get { return String.Format("Mmol/L"); }
        }

        /// <summary>
        /// current value converted to molar (mole/L)
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(10, -6);
        }
    }
}