using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Mace : IWeapon
    {
        public Mace(string name)
        {
            this.Name = name;
            this.AttackDamage = 25;
            this.BlockingPower = 8;
            this.SpecialEffect = "bluntForceTrauma";
        }
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public string SpecialEffect { get; private set; }
    }
}
