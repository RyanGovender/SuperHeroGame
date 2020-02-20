using SuperHeroGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroGame.LogicLayer
{
    public class FighterLogicLayer
    {
        public static int minValue = 0;
        public static int maxValue = 0;
        public static void DisplayAllSuperHeros()
        {
            foreach(var item in DataLayer.GetAllSuperHeros())
            {
                Console.WriteLine($"\t({item.FighterId}) - {item.Alias}");
            }
        }

        public static void DisplayAllVillians()
        {
            foreach (var item in DataLayer.GetAllVillains())
            {
                Console.WriteLine($"\t({item.FighterId}) - {item.Alias}");
            }
        }

        public static void GetFighter(int id,List<Fighter> data)
        {
            foreach(var item in data)
            {
                if(item.FighterId == id)
                {
                    Console.WriteLine($"----------------" +
                        $"\nName : {item.Name} {item.Surname}" +
               $"\nAlias : {item.Alias}" +
               $"\nPhysical Strength : {item.PhysicalStrength}/10" +
               $"\nAttack Points : {item.AttackPoints}/10" +
               $"\nSpeed : {item.Speed}/10" +
               $"\n---------------");
                }
            }
        }

        public static Fighter fighter(int id)
        {
            return DataLayer.GetAllSuperHeros().Find(x => x.FighterId == id);
        }
        public static Fighter fighterEvil(int id)
        {
            return DataLayer.GetAllVillains().Find(x => x.FighterId == id);
        }

        public static void GetValues()
        {
            int rounds = 0;
            foreach (var item in DataLayer.GetAllVillains())
            {
                if (rounds == 0) minValue++;
                maxValue = item.FighterId;
            }
        }
    }
}
