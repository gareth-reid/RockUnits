using System;

namespace RockUnit.Unit.Mole
{
    public class Mole : Unit
    {
        public Mole(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return String.Format("mol"); }
        }

        public override float GetNormalized()
        {
            return Value;
        }
    }
}