using InitiativeTracker.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InitiativeTracker.CustomControls
{
    public partial class InitiativeControl : UserControl
    {
        public int _initiative;
        public string _name;
        public int _hitpoints;

        public InitiativeControl(Combatant c, int init)
        {
            InitializeComponent();

            _initiative = init;
            _name = c.Name;
            _hitpoints = c.HitPoints;
        }
    }
}
