using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class Firefighter
    {
        public int IdFirefighter { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<FirefighterAction> FirefighterActions { get; set; }
    }
}
