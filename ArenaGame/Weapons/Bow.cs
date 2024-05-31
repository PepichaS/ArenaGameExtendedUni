using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon
    {
        public Bow(string name)
        {
            this.Name = name;
            this.AttackDamage = 50;
            this.BlockingPower = 0;
            this.SpecialEffect = "trueArrow";
        }
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public string SpecialEffect { get; private set; }
    }
}
