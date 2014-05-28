using System;
using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.MicroMolePerLitreTests
{
    public class GramPerLitreNewWithValueNormalized : UnitTest
    {
        private GramPerLitre _m = new GramPerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new GramPerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            Assert.AreEqual(_value, _m.GetNormalized());
        }
    }
}