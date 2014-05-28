namespace RockUnit.Unit.TimeBased
{
    public class MilliLetreMinute : Unit
    {
        public MilliLetreMinute(float value = 0)
        {
            Value = value;
        }

        //e.g. Creatine clearance
        public override string ShortUnit
        {
            get { return "mL/min"; }
        }

        /// <summary>
        /// current value converted to  ML per second
        /// </summary>
        /// <returns></returns>
        public override float GetNormalized()
        {
            return Value * 60;
        }
    }
}