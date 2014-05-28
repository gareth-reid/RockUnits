
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace RockUnit.UnitTest
{
    [TestFixture]
    public abstract class UnitTest
    {
        public Fixture Fixture = new Fixture();
        [SetUp]
        protected virtual void When()
        {}
    }
}
