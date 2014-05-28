using NUnit.Framework;
using RockUnit.Unit.Mole;

namespace RockUnit.UnitTest.Unit.MoleTests.MilliMoleTests
{
    public class MilliMoleNew : UnitTest
    {
        private MilliMole _mm = new MilliMole();
        
        protected override void When()
        {
            _mm = new MilliMole();
        }

        [Then]
        public void ShortUnitShouldEquEqual_mmol()
        {
            Assert.AreEqual("mmol", _mm.ShortUnit);
        }
    }
}