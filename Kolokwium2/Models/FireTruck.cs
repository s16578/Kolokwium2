using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class FireTruck
    {
        public int IdFireTruck { get; set; }
        public string OperationalNumber { get; set; }
        public bool SpecialEquipment { get; set; }
        public ICollection<FireTruckAction> FireTruckActions { get; set; }
    }
}
