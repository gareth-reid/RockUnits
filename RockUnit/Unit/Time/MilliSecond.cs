namespace RockUnit.Unit.Time
{
    public class MilliSecond : Unit
    {
        public MilliSecond(float value = 0)
        {
            Value = value;
        }

        public override string ShortUnit
        {
            get { return "ms"; }
        }

        /// <summary>
        /// current value converted to seconds
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value / 1000;
        }
    }
}