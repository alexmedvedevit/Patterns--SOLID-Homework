using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.ElfUnits
{
    public class ElfMage : Mage
    {
        public ElfMage()
        {
            this.MaxHealth = 15;
            this.Health = this.MaxHealth;
            this.Damage = 0;
            this.HealingAmount = 8;
        }
    }
}