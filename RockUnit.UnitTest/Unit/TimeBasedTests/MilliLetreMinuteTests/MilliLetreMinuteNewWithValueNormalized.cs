using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliLetreMinuteTests
{
    public class MilliLetreMinuteNewWithValueNormalized : UnitTest
    {
        private MilliLetreMinute _m = new MilliLetreMinute();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliLetreMinute(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value * 60;
            Assert.AreEqual(normalized, _m.GetNormalized());
        }
    }
}