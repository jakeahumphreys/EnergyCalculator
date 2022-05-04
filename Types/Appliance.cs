using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Types
{
    public class Appliance
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal StandbyWatts { get; set; }
        public decimal UsageWatts { get; set; }
    }
}
