namespace RockUnit.Unit.Metre
{
    public class MilliMetre : Unit
    {
        public MilliMetre(float value = 0)
        {
            Value = value;
        }
        public override string ShortUnit
        {
            get { return "mm"; }
        }

        /// <summary>
        /// current value converted to metre
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value / 1000; 
        }
    }
}