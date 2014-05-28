using System;

namespace RockUnit.Unit.Time
{
    public class Second : Unit
    {
        public Second(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return String.Format("s"); }
        }

        public override float GetNormalized()
        {
            return Value;
        }
    }
}