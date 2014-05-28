using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Metre;

namespace RockUnit.UnitTest.Unit.MetreTests
{
    public class MetreNewWithValue : UnitTest
    {
        private Metre _m = new Metre();
        private float _value = 0;
        protected override void When()
        {
            _m = new Metre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}