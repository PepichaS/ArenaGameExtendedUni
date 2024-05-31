using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Barbarian : Hero
    {
        public Barbarian(string name, double armor, double strenght, IWeapon weapon, IWeapon offHand) : base(name, armor, strenght, weapon)
        {
            this.WeaponOffHand = offHand;
        }

        public IWeapon WeaponOffHand { get; set; }

        public override double Attack()
        {
            double damage = base.Attack();

            double totalDamage = Strenght + WeaponOffHand.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double realDamage = totalDamage * (coef / 100);

            bool trigger = random.NextDouble() > 0.5 ? true : false;
            string effect = WeaponOffHand.SpecialEffect;

            if (trigger)
            {
                if (effect == "doubleAttack")
                {
                    realDamage *= 2;
                }
                else if (effect == "longReach")
                {
                    realDamage *= 1.5;
                }
                else if (effect == "bluntForceTrauma")
                {
                    realDamage *= 1.3;
                    realDamage *= 1.9;
                }
                else if (effect == "poison")
                {
                    // 5 ticks
                    for (int i = 0; i < 5; i++)
                    {
                        realDamage *= 1.1;
                    }
                }
                else if (effect == "trueArrow")
                {
                    realDamage *= 2.5;
                }
            }

            return realDamage + damage;
        }
    }
}
