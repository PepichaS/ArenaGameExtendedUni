using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Hunter : Hero
    {
        public Hunter(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        public override double Defend(double damage)
        {
            // Dodge ability
            double probability = random.NextDouble();
            if (probability < 0.10)
            {
                return 0;   
            }
            return base.Defend(damage);
        }
    }
}
