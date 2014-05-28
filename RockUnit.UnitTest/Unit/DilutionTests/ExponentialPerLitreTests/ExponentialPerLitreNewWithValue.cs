using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.ExponentialPerLitreTests
{
    public class ExponentialPerLitreNewWithValue : UnitTest
    {
        private ExponentialPerLitre _m = new ExponentialPerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new ExponentialPerLitre(_value = Fixture.Create<float>());
            _m.ExponentialMultiplier = new Exponential(10, 9);
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}