using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.OrcUnits
{
    public class OrcArcher : Archer
    {
        public OrcArcher()
        {
            this.MaxHealth = 20;
            this.Health = this.MaxHealth;
            this.Damage = 3;
        }
    }
}