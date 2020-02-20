using SuperHeroGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroGame.LogicLayer
{
    public class DataLayer
    {
        public static List<SuperHero> GetAllSuperHeros()
        {
            var superheros = new List<SuperHero>
            {
                new SuperHero("Super-Soldier",1,"Steve","Rogers","Captain America","All human Vulnerabilities",100,7,7,8),
                new SuperHero("superhuman ",2,"Clark","Kent","Superman","Kryptonite",100,9,8,8),
            };
            return superheros;
        }

        public static List<Villian> GetAllVillains()
        {
            var villians = new List<Villian>
            {
                new Villian(true,4,"Floyd","Lawton","Deadshot","has a deathwish",100,6,8,7),
                new Villian(true,3," "," ","Thanos ","None",100,9,9,10)
            };
            return villians;
        }
    }
}
