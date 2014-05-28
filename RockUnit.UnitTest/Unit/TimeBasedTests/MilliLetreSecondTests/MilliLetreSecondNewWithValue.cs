using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.TimeBased;

namespace RockUnit.UnitTest.Unit.TimeBasedTests.MilliLetreSecondTests
{
    public class MilliLetreSecondNewWithValue : UnitTest
    {
        private MilliLetreSecond _m = new MilliLetreSecond();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliLetreSecond(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}