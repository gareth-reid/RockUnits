using System;

namespace RockUnit.Unit.Reaction
{
    /// <summary>
    /// This is common in pathology results for measuring the enzymatic activity level in enzyme catalysis
    /// </summary>
    public class ExponentialKatal : Unit
    {
        public ExponentialKatal(float value = 0)
        {
            Value = value;
        }
        
        public override string UnitDescriber
        {
            get
            {
                return String.Format("*{0}^{1}/Kat", ExponentialMultiplier.Base, ExponentialMultiplier.Power);
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