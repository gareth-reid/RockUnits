using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.Dilution.NanoMolePerLitreTests
{
    public class NanoMolePerLitreNewWithValue : UnitTest
    {
        private NanoMolePerLitre _m = new NanoMolePerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new NanoMolePerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}