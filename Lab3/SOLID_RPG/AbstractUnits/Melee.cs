using System;

namespace SOLID_RPG.AbstractUnits
{
    public class Melee : AbstractUnit
    {
        public void DealDamage(AbstractUnit unit)
        {
            Console.WriteLine(this.GetType().Name+" attacks "+unit.GetType().Name+" with his sword and deals him "+this.Damage+" points of damage.");
            unit.ReceiveDamage(this.Damage);
        }
    }
}