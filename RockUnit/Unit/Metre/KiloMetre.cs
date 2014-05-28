namespace RockUnit.Unit.Metre
{
    public class KiloMetre : Unit
    {
        public KiloMetre(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return "km"; }
        }

        /// <summary>
        /// current value converted to metre
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * 1000; 
        }
    }
}