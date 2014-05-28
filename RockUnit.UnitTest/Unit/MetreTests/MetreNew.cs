using NUnit.Framework;
using RockUnit.Unit.Metre;

namespace RockUnit.UnitTest.Unit.MetreTests
{
    public class MetreNew : UnitTest
    {
        private Metre _mm = new Metre();
        
        protected override void When()
        {
            _mm = new Metre();
        }

        [Then]
        public void ShortUnitShouldEquEqual_m()
        {
            Assert.AreEqual("m", _mm.ShortUnit);
        }
    }
}