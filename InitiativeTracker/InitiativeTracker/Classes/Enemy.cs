using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeTracker.Classes
{
    public class Enemy : Combatant
    {
        // For legendary creatures
        public bool IsLegendary { get; set; }
        public int LegendaryActions { get; set; }

        // For enemies with lair actions
        public bool HasLairActions { get; set; }
        public int LairActionInitiative { get; set; }

        public Enemy(string name, int hp)
        {
            this.Name = name;
            this.HitPoints = hp;
        }

        public void SetLegendary(int numLA)
        {
            this.IsLegendary = true;
            this.LegendaryActions = numLA;
        }

        public void SetLair(int lairInit)
        {
            this.HasLairActions = true;
            this.LairActionInitiative = lairInit;
        }
    }
}
