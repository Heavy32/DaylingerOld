using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daylinger.Models
{
    public class DaylingerLogic
    {
        public DayConstructor DayConstructor { get; set; }
        public DayTemplate DayTemplate { get; set; }
        public EfficiencyCalculator EfficiencyCalculator { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}
