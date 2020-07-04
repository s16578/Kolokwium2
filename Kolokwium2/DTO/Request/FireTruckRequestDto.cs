using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.DTO.Request
{
    public class FireTruckRequestDto
    {
        public int IdFireTruck { get; set; }
        public int IdAction { get; set; }
        public bool? NeedSpecialEquipment { get; set; }
    }
}
