using NUnit.Framework;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliLetreMinuteTests
{
    public class MilliLetreMinuteNew : UnitTest
    {
        private MilliLetreMinute _mm = new MilliLetreMinute();
        
        protected override void When()
        {
            _mm = new MilliLetreMinute();
        }

        [Then]
        public void ShortUnitShouldEquEqual_mLmin()
        {
            Assert.AreEqual("mL/min", _mm.ShortUnit);
        }
    }
}