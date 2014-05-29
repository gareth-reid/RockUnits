using NUnit.Framework;
using RockUnit.Unit.Mole;

namespace RockUnit.UnitTest.Unit.MoleTests.MoleTests
{
    public class MoleNew : UnitTest
    {
        private Mole _m = new Mole();
        
        protected override void When()
        {
            _m = new Mole();
        }

        [Then]
        public void ShortUnitShouldEquEqual_mol()
        {
            Assert.AreEqual("mol", _m.UnitDescriber);
        }
    }
}