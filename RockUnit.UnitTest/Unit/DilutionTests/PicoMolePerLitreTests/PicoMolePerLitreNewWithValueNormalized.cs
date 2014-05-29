using System;
using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.PicoMolePerLitreTests
{
    public class PicoMolePerLitreNewWithValueNormalized : UnitTest
    {
        private PicoMolePerLitre _m = new PicoMolePerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new PicoMolePerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value * (float)Math.Pow(10, -12);
            Assert.AreEqual(normalized, _m.GetNormalized());
        }
    }
}