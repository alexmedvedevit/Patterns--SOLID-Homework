using System;
using SOLID_RPG.ElfUnits;
using SOLID_RPG.OrcUnits;

namespace SOLID_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Gang elvenGang = new Gang("Mirkwood", new ElfUnitsFactory());
            Gang orcGang = new Gang("Mordor", new OrcUnitsFactory());

            string teamHasWon = "";
            
            Console.WriteLine("Let the battle until the first blood begin!");

            while (true)
            {
                orcGang.Combat(elvenGang);
                if (elvenGang.Melee.Health == 0 || elvenGang.Archer.Health == 0 || elvenGang.Mage.Health == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("The battle is over! "+orcGang.Name+" have won!");
                    break;
                }
                elvenGang.Combat(orcGang);
                if (orcGang.Melee.Health == 0 || orcGang.Archer.Health == 0 || orcGang.Mage.Health == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("The battle is over! "+elvenGang.Name+" have won!");
                    break;
                }
            }
        }
    }
}