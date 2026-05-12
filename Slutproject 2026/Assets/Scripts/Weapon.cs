using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    //Ian
    public class Weapon : Abilities
    {
        public Weapon(string name, int dmg, int cost, int targetLimit) : base(name, dmg, cost, targetLimit)
        {
            
        }
    }
}
