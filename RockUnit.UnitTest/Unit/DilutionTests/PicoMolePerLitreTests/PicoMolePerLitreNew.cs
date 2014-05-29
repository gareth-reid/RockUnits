using NUnit.Framework;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.PicoMolePerLitreTests
{
    public class PicoMolePerLitreNew : UnitTest
    {
        private PicoMolePerLitre _mm = new PicoMolePerLitre();
        
        protected override void When()
        {
            _mm = new PicoMolePerLitre();
        }

        [Then]
        public void ShortUnitShouldEquEqual_nmolL()
        {
            Assert.AreEqual("pmol/L", _mm.UnitDescriber);
        }
    }
}