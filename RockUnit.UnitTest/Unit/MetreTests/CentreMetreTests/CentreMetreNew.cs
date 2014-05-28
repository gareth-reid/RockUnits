using NUnit.Framework;
using RockUnit.Unit.Metre;

namespace RockUnit.UnitTest.Unit.MetreTests.CentreMetreTests
{
    public class CentreMetreNew : UnitTest
    {
        private CentreMetre _cm = new CentreMetre();
        
        protected override void When()
        {
            _cm = new CentreMetre();
        }

        [Then]
        public void ShortUnitShouldEqual_cm()
        {
            Assert.AreEqual("cm", _cm.ShortUnit);
        }
    }
}