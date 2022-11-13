using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.OrcUnits
{
    public class OrcMelee : Melee
    {
        public OrcMelee()
        {
            this.MaxHealth = 30;
            this.Health = this.MaxHealth;
            this.Damage = 5;
        }
    }
}