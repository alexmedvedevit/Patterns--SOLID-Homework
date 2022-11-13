namespace SOLID_RPG.AbstractUnits
{
    public interface IUnitFactory
    {
        Melee CreateMelee();
        Archer CreateArcher();
        Mage CreateMage();
    }
}