using NUnit.Framework;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliMole24HourTests
{
    public class MilliMole24HourNew : UnitTest
    {
        private MilliMole24Hour _mm = new MilliMole24Hour();
        
        protected override void When()
        {
            _mm = new MilliMole24Hour();
        }

        [Then]
        public void ShortUnitShouldEquEqual_mmol24h()
        {
            Assert.AreEqual("mmol/24h", _mm.ShortUnit);
        }
    }
}