using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    //Ian
    public class Spell : Abilities
    {
        int cooldown;
        public Spell(string name, int dmg, int cost, int targetLimit, int cooldown) : base(name, dmg, cost, targetLimit)
        {
            this.cooldown = cooldown;
        }
    }
}
