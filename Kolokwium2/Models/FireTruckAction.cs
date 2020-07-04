using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class FireTruckAction
    {
        public int IdFireTruckAction { get; set; }
        public int IdFireTruck { get; set; }
        public int IdAction { get; set; }
        public DateTime AssignmentDate { get; set; }
        [ForeignKey("IdFireTruck")]
        public virtual FireTruck FireTruck { get; set; }
        [ForeignKey("IdAction")]
        public virtual ActionEntity ActionEntity { get; set; }
    }
}
