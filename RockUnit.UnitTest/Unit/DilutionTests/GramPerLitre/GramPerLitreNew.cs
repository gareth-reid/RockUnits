using NUnit.Framework;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.MicroMolePerLitreTests
{
    public class GramPerLitreNew : UnitTest
    {
        private GramPerLitre _mm = new GramPerLitre();
        
        protected override void When()
        {
            _mm = new GramPerLitre();
        }

        [Then]
        public void ShortUnitShouldEquEqual_MmolL()
        {
            Assert.AreEqual("g/L", _mm.UnitDescriber);
        }
    }
}