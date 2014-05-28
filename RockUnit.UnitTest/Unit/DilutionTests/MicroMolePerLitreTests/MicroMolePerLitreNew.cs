using NUnit.Framework;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.MicroMolePerLitreTests
{
    public class MicroMolePerLitreNew : UnitTest
    {
        private MicroMolePerLitre _mm = new MicroMolePerLitre();
        
        protected override void When()
        {
            _mm = new MicroMolePerLitre();
        }

        [Then]
        public void ShortUnitShouldEquEqual_MmolL()
        {
            Assert.AreEqual("Mmol/L", _mm.ShortUnit);
        }
    }
}