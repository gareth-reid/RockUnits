using NUnit.Framework;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.Dilution.NanoMolePerLitreTests
{
    public class NanoMolePerLitreNew : UnitTest
    {
        private NanoMolePerLitre _mm = new NanoMolePerLitre();
        
        protected override void When()
        {
            _mm = new NanoMolePerLitre();
        }

        [Then]
        public void ShortUnitShouldEquEqual_nmolL()
        {
            Assert.AreEqual("nmol/L", _mm.UnitDescriber);
        }
    }
}