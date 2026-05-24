using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    //Ian
    //Alexander(Ändrade dmg till Abilitydmg)
    public class Spell : Abilities
    {
        public int cooldown;
        public Spell(string name, int Abilitydmg, int cost, int targetLimit, int cooldown) : base(name, Abilitydmg, cost, targetLimit)
        {
            this.cooldown = cooldown;
        }
    }
}
