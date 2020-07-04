using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class ActionEntity
    {
        public int IdAction { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool NeedSpecialEquipment { get; set; }
        public ICollection<FireTruckAction> FireTruckActions { get; set; }
        public ICollection<FirefighterAction> FirefighterActions { get; set; }
    }
}
