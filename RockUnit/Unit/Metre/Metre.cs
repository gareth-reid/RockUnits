namespace RockUnit.Unit.Metre
{
    public class Metre : Unit
    {
        public Metre(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return "m"; }
        }
        public override float GetNormalized()
        {
            return Value;
        }
    }
}