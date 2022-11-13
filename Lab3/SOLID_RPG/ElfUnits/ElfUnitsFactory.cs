using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG.ElfUnits
{
    public class ElfUnitsFactory : IUnitFactory
    {
        public Melee CreateMelee()
        {
            return new ElfMelee();
        }

        public Archer CreateArcher()
        {
            return new ElfArcher();
        }

        public Mage CreateMage()
        {
            return new ElfMage();
        }
    }
}