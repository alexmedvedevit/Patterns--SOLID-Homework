using System;

namespace SOLID_RPG.AbstractUnits
{
    public abstract class AbstractUnit
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public int MaxHealth { get; set; }
        

        public void ReceiveDamage(int damageAmount)
        {
            if (this.Health - damageAmount < 0)
            {
                this.Health = 0;
                Console.WriteLine(this.GetType().Name+" has died");
            }
            else
            {
                this.Health -= damageAmount;
                Console.WriteLine(this.GetType().Name+"'s health is now "+this.Health);
            }

        }
        
        public void ReceiveHealing(int healingAmount)
        {
            if (this.Health + healingAmount > this.MaxHealth)
                this.Health = this.MaxHealth;
            else
                this.Health += healingAmount;
            
            Console.WriteLine(this.GetType().Name+"'s health is now "+this.Health);
        }
    }
}