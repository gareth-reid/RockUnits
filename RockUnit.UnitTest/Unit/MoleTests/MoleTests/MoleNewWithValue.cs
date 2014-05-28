using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Mole;

namespace RockUnit.UnitTest.Unit.MoleTests.MoleTests
{
    public class MoleNewWithValue : UnitTest
    {
        private Mole _m = new Mole();
        private float _value = 0;
        protected override void When()
        {
            _m = new Mole(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}