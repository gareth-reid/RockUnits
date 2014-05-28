using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockUnit;
using RockUnit.Unit;
using RockUnit.Unit.Metre;
using RockUnit.Unit.Time;

namespace TestConsole
{
    class Program
    {
        static void Main()
        {
            IList<Unit> units = new List<Unit>();
            units.Add(new MilliMetre() { Value = 12.1f });
            units.Add(new CentreMetre() { Value = 12.1f });
            units.Add(new PlanckSecond() { Value = 12.1f });

            foreach (var u in units)
            {
                Console.WriteLine(u.Value + u.ShortUnit + " -normalized: " + u);
            }

            var cm = new CentreMetre();
            Console.WriteLine(cm.GetUnitName());
        }
    }
}
