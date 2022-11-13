using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.ElfUnits
{
    public class ElfArcher : Archer
    {
        public ElfArcher()
        {
            this.MaxHealth = 15;
            this.Health = this.MaxHealth;
            this.Damage = 5;
        }
    }
}