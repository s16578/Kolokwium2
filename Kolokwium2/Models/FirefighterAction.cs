using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class FirefighterAction
    {
        public int IdFirefighter { get; set; }
        public int IdAction { get; set; }
        [ForeignKey("IdAction")]
        public virtual ActionEntity ActionEntity { get; set; }
        [ForeignKey("IdFirefighter")]
        public virtual Firefighter Firefighter { get; set; }
    }
}
