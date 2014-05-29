using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.PicoMolePerLitreTests
{
    public class PicoMolePerLitreNewWithValue : UnitTest
    {
        private PicoMolePerLitre _m = new PicoMolePerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new PicoMolePerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}