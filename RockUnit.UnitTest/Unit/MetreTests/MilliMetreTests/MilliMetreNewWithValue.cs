using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Metre;

namespace RockUnit.UnitTest.Unit.MetreTests.MilliMetreTests
{
    public class MilliMetreNewWithValue : UnitTest
    {
        private MilliMetre _mm = new MilliMetre();
        private float _value = 0;
        protected override void When()
        {
            _mm = new MilliMetre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _mm.Value);
        }
    }
}