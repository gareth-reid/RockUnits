using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliMole24HourTests
{
    public class MilliMole24HourNewWithValue : UnitTest
    {
        private MilliMole24Hour _m = new MilliMole24Hour();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliMole24Hour(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}