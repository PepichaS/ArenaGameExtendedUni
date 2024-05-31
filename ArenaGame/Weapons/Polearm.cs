using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Polearm : IWeapon
    {
        public Polearm(string name)
        {
            this.Name = name;
            this.AttackDamage = 23;
            this.BlockingPower = 5.5;
            this.SpecialEffect = "longReach";
        }
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public string SpecialEffect { get; private set; }
    }
}
