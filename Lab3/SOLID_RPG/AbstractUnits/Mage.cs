using System;

namespace SOLID_RPG.AbstractUnits
{
    public class Mage : AbstractUnit
    {
        public int HealingAmount { get; set; }
        
        public void Heal(AbstractUnit unit)
        {
            Console.WriteLine(this.GetType().Name+" heals "+unit.GetType().Name+" with his magic spells and restores him "+this.HealingAmount+" points of health.");
            unit.ReceiveHealing(this.HealingAmount);
        }
    }
}