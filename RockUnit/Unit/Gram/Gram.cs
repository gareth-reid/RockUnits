namespace RockUnit.Unit.Gram
{
    public class Gram : Unit
    {
        public Gram(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return "g"; }
        }
        
        public override float GetNormalized()
        {
            return Value;
        }
    }
}