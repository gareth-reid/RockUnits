using System;
using System.Reflection;

namespace RockUnit.Unit.Dilution
{
    /// <summary>
    /// This is common in pathology results for things platelet counts i.e. 8.5 *10^9/L
    /// </summary>
    public class ExponentialPerLitre : Unit
    {

        public ExponentialPerLitre(float value = 0)
        {
            Value = value;
        }
        
        public override string ShortUnit
        {
            get
            {
                return String.Format("*{0}^{1}/L", ExponentialMultiplier.Base, ExponentialMultiplier.Power);
            }
        }

        /// <summary>
        /// Value multiplied by exponotial part
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * (float)Math.Pow(ExponentialMultiplier.Base, ExponentialMultiplier.Power);
        }
    }
}