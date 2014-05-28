using System;
using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.MicroMolePerLitreTests
{
    public class MicroMolePerLitreNewWithValueNormalized : UnitTest
    {
        private MicroMolePerLitre _m = new MicroMolePerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new MicroMolePerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value * (float)Math.Pow(10, -6);
            Assert.AreEqual(normalized, _m.GetNormalized());
        }
    }
}