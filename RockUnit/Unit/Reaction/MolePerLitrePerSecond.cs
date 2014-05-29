using System;

namespace RockUnit.Unit.Reaction
{
    /// <summary>
    /// This is common in chemistry for reaction rate
    /// </summary>
    public class MolePerLitrePerSecond : Unit
    {

        public MolePerLitrePerSecond(float value = 0)
        {
            Value = value;
        }
        
        public override string UnitDescriber
        {
            get
            {
                return String.Format("mol/L*s");
            }
        }

        /// <summary>
        /// Value multiplied by exponotial part
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value;
        }
    }
}