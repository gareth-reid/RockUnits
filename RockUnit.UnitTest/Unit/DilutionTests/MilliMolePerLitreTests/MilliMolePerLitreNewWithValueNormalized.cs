﻿using System;
using NUnit.Framework;
using Ploeh.AutoFixture;
using RockUnit.Unit.Dilution;

namespace RockUnit.UnitTest.Unit.Dilution.MilliMolePerLitreTests
{
    public class MilliMolePerLitreNewWithValueNormalized : UnitTest
    {
        private MilliMolePerLitre _m = new MilliMolePerLitre();
        private float _value = 0;
        protected override void When()
        {
            _m = new MilliMolePerLitre(_value = Fixture.Create<float>());
        }

        [Then]
        public void ShouldEqualValueNormalized()
        {
            var normalized = _value * (float)Math.Pow(10, -3);
            Assert.AreEqual(normalized, _m.GetNormalized());
        }
    }
}