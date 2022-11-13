using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.OrcUnits
{
    public class OrcMage : Mage
    {
        public OrcMage()
        {
            this.MaxHealth = 20;
            this.Health = this.MaxHealth;
            this.Damage = 0;
            this.HealingAmount = 5;
        }
    }
}