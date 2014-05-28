using NUnit.Framework;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.DilutionTests.ExponentialPerLitreTests
{
    public class ExponentialPerLitreNew : UnitTest
    {
        private ExponentialPerLitre _mm = new ExponentialPerLitre();
        
        protected override void When()
        {
            _mm = new ExponentialPerLitre();
            _mm.ExponentialMultiplier = new Exponential(10, 9);
        }

        [Then]
        public void ShortUnitShouldEquEqual_MmolL()
        {
            Assert.AreEqual("*10^9/L", _mm.ShortUnit);
        }
    }
}