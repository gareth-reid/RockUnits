using System;

namespace RockUnit.Unit.Gram
{
    public class Gram : Unit
    {
        public Gram(float value = 0)
        {
            Value = value;
        }

        public override string UnitDescriber
        {
            get { return String.Format("g"); }
        }
        
        public override float GetNormalized()
        {
            return Value;
        }
    }
}