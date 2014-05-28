using System;

namespace RockUnit.Unit.Time
{
    public class PlanckSecond : Unit
    {
        public PlanckSecond(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return "p"; }
        }

        /// <summary>
        /// current value converted to seconds
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            var a =  Value * (float)Math.Pow(10, -44);
            return a;
        }
    }
}