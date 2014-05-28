using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Metre;

namespace RockUnit.UnitTest.Unit.MetreTests.MilliMetreTests
{
    public class MilliMetreNewWithValueNormalized : UnitTest
    {
        private MilliMetre _mm = new MilliMetre();
        private float _value = 0;
        protected override void When()
        {
            _mm = new MilliMetre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value/1000;
            Assert.AreEqual(normalized, _mm.GetNormalized());
        }
    }
}