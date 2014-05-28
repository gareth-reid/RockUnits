using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliLetreMinuteTests
{
    public class MilliLetreSecondNewWithValueNormalized : UnitTest
    {
        private MilliLetreSecond _m = new MilliLetreSecond();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliLetreSecond(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            Assert.AreEqual(_value, _m.GetNormalized());
        }
    }
}