using System;

namespace SOLID_RPG.AbstractUnits
{
    public class Archer : AbstractUnit
    {
        public void DealDamage(AbstractUnit unit)
        {
            Console.WriteLine(this.GetType().Name+" shots "+unit.GetType().Name+" with his bow and deals him "+this.Damage+" points of damage.");
            unit.ReceiveDamage(this.Damage);
        }
    }
}