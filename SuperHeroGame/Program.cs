using SuperHeroGame.LogicLayer;
using System;

namespace SuperHeroGame
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterfaceLogic.Run();
            //Console.WriteLine("Who do you want to be :" +
            //    "\n(0) - Super Hero" +
            //    "\n(1) - Villian");
            //string input = Console.ReadLine();
            //if(input.Equals("0"))
            //{
            //    FighterLogicLayer.DisplayAllSuperHeros();
            //    Console.WriteLine("Please select the super hero you want to use.");
            //    int value = int.Parse(Console.ReadLine());
            //    FighterLogicLayer.GetFighter(value);
            //    Console.WriteLine("(0) - Continue with this fighter.");
            //    if(Console.ReadLine().Equals("0"))
            //    {
            //        FighterLogicLayer.DisplayAllVillians();
            //        Console.WriteLine("Select your opponent.");
            //        var sim = new SimulateGame(DataLayer.GetAllSuperHeros().Find(x => x.FighterId == value), DataLayer.GetAllVillains().Find(x => x.FighterId == 2));
            //        sim.CreateFighterCards();
            //        sim.PlayGame();
            //    }
            //}
            //else
            //{
            //    FighterLogicLayer.DisplayAllVillians();
            //    Console.WriteLine("Please select the villian you want to use.");
            //}
        
        }
    }
}
