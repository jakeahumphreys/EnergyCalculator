using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyCalculator.Calculations
{
    public static class CalculationService
    {
        public const int HOURS_OF_USE = 24;
        public static decimal CalculateDailyCost(decimal watts, decimal costPerKwh)
        {
            var kwH = watts / 1000;
            var hoursKwh = kwH * HOURS_OF_USE;

            return hoursKwh * costPerKwh;
        }
    }
}
