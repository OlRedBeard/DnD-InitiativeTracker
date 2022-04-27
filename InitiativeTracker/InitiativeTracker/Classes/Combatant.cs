using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker.Classes
{
    [Serializable]
    public class Combatant
    {
        public int HitPoints { get; set; }
        public string Name { get; set; }
    }
}
