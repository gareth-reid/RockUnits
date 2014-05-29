using NUnit.Framework;
using RockUnit.Unit.Dilution;
using RockUnit.Unit.Reaction;

namespace RockUnit.UnitTest.Unit.ReactionTests.ExponentialKatalTests
{
    public class ExponentialKatalNew : UnitTest
    {
        private ExponentialKatal _mm = new ExponentialKatal();
        
        protected override void When()
        {
            _mm = new ExponentialKatal();
            _mm.ExponentialMultiplier = new Exponential(10, 9);
        }

        [Then]
        public void ShortUnitShouldEquEqual_MmolL()
        {
            Assert.AreEqual("*10^9/Kat", _mm.UnitDescriber);
        }
    }
}