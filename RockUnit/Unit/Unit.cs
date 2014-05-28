﻿using System;

namespace RockUnit.Unit
{
    public abstract class Unit
    {
        public abstract float GetNormalized(); //i.e. millimeter = meteres
        public float Value { get; set; }
        public abstract string ShortUnit { get; }

        public string GetUnitName()
        {
            var type = GetType().ToString().Split('.');
            return type[type.Length - 1];
        }
    }
}
