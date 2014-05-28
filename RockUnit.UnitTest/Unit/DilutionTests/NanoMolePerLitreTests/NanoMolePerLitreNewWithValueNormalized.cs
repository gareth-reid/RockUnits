using System;
using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.Dilution.MilliMolePerLitreTests
{
    public class NanoMolePerLitreNewWithValueNormalized : UnitTest
    {
        private NanoMolePerLitre _m = new NanoMolePerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new NanoMolePerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value * (float)Math.Pow(10, -9);
            Assert.AreEqual(normalized, _m.GetNormalized());
        }
    }
}