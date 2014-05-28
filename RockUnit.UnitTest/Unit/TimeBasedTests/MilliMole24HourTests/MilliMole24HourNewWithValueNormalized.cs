using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliMole24HourTests
{
    public class MilliMole24HourNewWithValueNormalized : UnitTest
    {
        private MilliMole24Hour _m = new MilliMole24Hour();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliMole24Hour(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value * 24 * 60 * 60;
            Assert.AreEqual(normalized, _m.GetNormalized());
        }
    }
}