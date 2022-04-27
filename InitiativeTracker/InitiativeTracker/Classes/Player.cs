using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker.Classes
{
    public class Player : Combatant
    {
        public Player(string name, int hp)
        {
            this.Name = name;
            this.HitPoints = hp;
        }
    }
}
