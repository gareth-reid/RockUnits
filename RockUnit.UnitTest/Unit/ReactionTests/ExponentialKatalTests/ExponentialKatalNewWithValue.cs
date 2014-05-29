using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;
using RockUnit.Unit.Reaction;

namespace RockUnit.UnitTest.Unit.ReactionTests.ExponentialKatalTests
{
    public class ExponentialKatalNewWithValue : UnitTest
    {
        private ExponentialKatal _m = new ExponentialKatal();
        private float _value = 0;
        protected override void When()
        {
            _m = new ExponentialKatal(_value = Fixture.Create<float>());
            _m.ExponentialMultiplier = new Exponential(10, 9);
        }

        [Then]
        public void ShouldEqualValue()
        {
            Assert.AreEqual(_value, _m.Value);
        }
    }
}