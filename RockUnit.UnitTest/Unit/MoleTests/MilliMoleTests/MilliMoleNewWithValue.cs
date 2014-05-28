using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;
using RockUnit.Unit.Mole;

namespace RockUnit.UnitTest.Unit.MoleTests.MilliMoleTests
{
    public class MilliMoleNewWithValue : UnitTest
    {
        private MilliMole _m = new MilliMole();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliMole(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}