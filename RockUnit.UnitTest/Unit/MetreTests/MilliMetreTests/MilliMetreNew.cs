using NUnit.Framework;
using RockUnit.Unit.Metre;

namespace RockUnit.UnitTest.Unit.MetreTests.MilliMetreTests
{
    public class MilliMetreNew : UnitTest
    {
        private MilliMetre _mm = new MilliMetre();
        
        protected override void When()
        {
            _mm = new MilliMetre();
        }

        [Then]
        public void ShortUnitShouldEqual_mm()
        {
            Assert.AreEqual("mm", _mm.UnitDescriber);
        }
    }
}