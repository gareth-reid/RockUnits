using System;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace RockUnit.UnitTest.Unit.DilutionTests.ExponentialPerLitreTests
{
    public class ExponentialPerLitreNewWithValueNormalized : UnitTest
    {
        private RockUnit.Unit.Dilution.ExponentialPerLitre _m = new RockUnit.Unit.Dilution.ExponentialPerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new RockUnit.Unit.Dilution.ExponentialPerLitre(_value = Fixture.Create<float>());
            _m.ExponentialMultiplier = new Exponential(10, 9);
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var _result = _value * (float)Math.Pow(10, 9);
            Assert.AreEqual(_result, _m.GetNormalized());
        }
    }
}