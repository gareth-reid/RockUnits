using NUnit.Framework;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliLetreSecondTests
{
    public class MilliLetreSecondNew : UnitTest
    {
        private MilliLetreSecond _mm = new MilliLetreSecond();
        
        protected override void When()
        {
            _mm = new MilliLetreSecond();
        }

        [Then]
        public void ShortUnitShouldEquEqual_mLs()
        {
            Assert.AreEqual("mL/s", _mm.ShortUnit);
        }
    }
}