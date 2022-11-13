using System;
using SOLID_RPG.AbstractUnits;

namespace SOLID_RPG
{
    class Gang
    {
        private IUnitFactory Factory;
        public string Name { get; set; }
        public Melee Melee; 
        public Archer Archer;
        public Mage Mage;

        public Gang(string name, IUnitFactory factory)
        {
            this.Name = name;
            this.Factory = factory;

            this.Melee = this.Factory.CreateMelee();
            this.Archer = this.Factory.CreateArcher();
            this.Mage = this.Factory.CreateMage();
        }

        public void Combat(Gang enemies)
        {
            Random rnd = new Random();
            int[] currentTurnAims = { rnd.Next(0, 2), rnd.Next(0, 2), rnd.Next(0, 2) };
            
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("It is a "+this.Name+"'s turn now! ");

            switch (currentTurnAims[0])
            {
                case 0: Melee.DealDamage(enemies.Melee);
                    break;
                case 1: Melee.DealDamage(enemies.Archer);
                    break;
                case 2: Melee.DealDamage(enemies.Mage);
                    break;
            }
            
            switch (currentTurnAims[1])
            {
                case 0: Archer.DealDamage(enemies.Melee);
                    break;
                case 1: Archer.DealDamage(enemies.Archer);
                    break;
                case 2: Archer.DealDamage(enemies.Mage);
                    break;
            }
            
            switch (currentTurnAims[2])
            {
                case 0: Mage.Heal(this.Melee);
                    break;
                case 1: Mage.Heal(this.Archer);
                    break;
                case 2: Mage.Heal(this.Mage);
                    break;
            }
        }
    }
}