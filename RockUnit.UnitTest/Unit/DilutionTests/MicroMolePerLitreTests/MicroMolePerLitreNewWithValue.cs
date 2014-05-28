using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.MicroMolePerLitreTests
{
    public class MicroMolePerLitreNewWithValue : UnitTest
    {
        private MicroMolePerLitre _m = new MicroMolePerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new MicroMolePerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}