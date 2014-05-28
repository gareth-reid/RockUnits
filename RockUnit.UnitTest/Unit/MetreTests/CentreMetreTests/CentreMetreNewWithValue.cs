using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Metre;

namespace RockUnit.UnitTest.Unit.MetreTests.CentreMetreTests
{
    public class CentreMetreNewWithValue : UnitTest
    {
        private CentreMetre _cm = new CentreMetre();
        private float _value = 0;
        protected override void When()
        {
            _cm = new CentreMetre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _cm.Value);
        }
    }
}