using System;
using System.Collections.Generic;
using System.Web.UI;

namespace RockUnit.Unit
{
    public abstract class Unit
    {
        public abstract float GetNormalized(); //i.e. millimeter = meteres
        public float Value { get; set; }
        public Exponential ExponentialMultiplier { get; set; }
        
        public abstract string ShortUnit { get; }

        public string GetUnitName()
        {
            var type = GetType().ToString().Split('.');
            return type[type.Length - 1];
        }
    }
}
