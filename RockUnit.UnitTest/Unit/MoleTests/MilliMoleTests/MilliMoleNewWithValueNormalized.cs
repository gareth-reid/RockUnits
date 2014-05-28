using System;
using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Mole;

namespace RockUnit.UnitTest.Unit.MoleTests.MilliMoleTests
{
    public class MilliMoleNewWithValueNormalized : UnitTest
    {
        private MilliMole _m = new MilliMole();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliMole(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value * (float)Math.Pow(10, -3);
            Assert.AreEqual(normalized, _m.GetNormalized());
        }
    }
}