RockUnits
=========

Units of measure library

Nuget: https://www.nuget.org/packages/RockUnit

Library of units of measure, specifically targeting pathology but I hope it can grow to include most. 

Currently: 
-Weight
-Length
-Dilution
-Reaction
-Molecular
-Time
-Timebased

Each type has a GetNormalizes method that converts to a like (most common) ratio for calculations. The method notes which explains for each unit are not coming through in the nuget package, need to fix this.

Conversions and methods to come.

This is to go into documentation eventually:
Normalization units
Dilution = mole/L
Length = metres
Liquid = litre
Molecular = mole
Reaction = exponential value
Time = seconds
Timebased = xxx per second
Weight = gram
