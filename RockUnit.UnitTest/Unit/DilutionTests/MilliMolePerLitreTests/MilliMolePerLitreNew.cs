using NUnit.Framework;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.Dilution.MilliMolePerLitreTests
{
    public class MilliMolePerLitreNew : UnitTest
    {
        private MilliMolePerLitre _mm = new MilliMolePerLitre();
        
        protected override void When()
        {
            _mm = new MilliMolePerLitre();
        }

        [Then]
        public void ShortUnitShouldEquEqual_mmolL()
        {
            Assert.AreEqual("mmol/L", _mm.ShortUnit);
        }
    }
}