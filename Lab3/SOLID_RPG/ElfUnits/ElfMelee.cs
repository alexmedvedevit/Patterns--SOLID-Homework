using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.ElfUnits
{
    public class ElfMelee : Melee
    {
        public ElfMelee()
        {
            this.MaxHealth = 30;
            this.Health = this.MaxHealth;
            this.Damage = 3;
        }
    }
}