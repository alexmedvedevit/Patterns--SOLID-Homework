using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.OrcUnits
{
    public class OrcUnitsFactory : IUnitFactory
    {
        public Melee CreateMelee()
        {
            return new OrcMelee();
        }

        public Archer CreateArcher()
        {
            return new OrcArcher();
        }

        public Mage CreateMage()
        {
            return new OrcMage();
        }
    }
}