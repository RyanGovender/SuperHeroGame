using SuperHeroGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperHeroGame.LogicLayer
{
    public class UserInterfaceLogic
    {
        private static int _minValue = 0;
        public static int _character;
        private static int _superHeroId;
        private static int _superHero = 1;
        public static int _villian = 2;
        private static int _continue = 1;
        private static int _selectNew = 2;
        private static Fighter f1;
        private static Fighter f2;
        private static SimulateGame sim;

        private static void ConsoleDisplay(string message)
        {
            Console.WriteLine(message);
        }

        public static void Run()
        {
            _character = GetUserInput("Who do you want to be :" +
                $"\n({_superHero}) - Super Hero" +
                $"\n({_villian}) - Villian", _minValue, _villian);
            if(_character == _superHero)
            {
                GetSuperHero();
                Continue();
                if(_continue ==_minValue+1)
                {
                    GetAllVillians();
                    StartGame(f1,f2);
                    sim.CreateFighterCards();
                    sim.PlayGame();
                }
            }
            else
            {

            }
        }

        public static void Continue()
        {
            _continue = GetUserInput($"\t({_continue}) - Continue with this fighter." +
                $"\t({_selectNew}) - Select a new fighter.", _minValue, _selectNew);
        }
        public static void StartGame(Fighter f1,Fighter f2)
        {
             sim = new SimulateGame(f1,f2);
        }

        public static void GetSuperHero()
        {
            FighterLogicLayer.DisplayAllSuperHeros();
            _superHeroId = GetUserInput("Please select the super hero you want to use.",_minValue,DataLayer.GetAllSuperHeros().Count);
             FighterLogicLayer.GetFighter(_superHeroId,DataLayer.GetAllSuperHeros().Cast<Fighter>().ToList());
             f1 = FighterLogicLayer.fighter(_superHero);
        }

        public static void GetAllVillians()
        {
             FighterLogicLayer.DisplayAllVillians();
            FighterLogicLayer.GetValues();
            _villian = GetUserInput("Please select the villian you want to use.", FighterLogicLayer.minValue, FighterLogicLayer.maxValue);
            FighterLogicLayer.GetFighter(_superHeroId, DataLayer.GetAllVillains().Cast<Fighter>().ToList());
            f2 = FighterLogicLayer.fighterEvil(_villian);
        }

        public static int GetUserInput(string message, int minValue, int maxValue)
        {
            int returnValue;
            string data;
            do
            {
                ConsoleDisplay(message);
                data = Console.ReadLine();

            } while (!int.TryParse(data, out returnValue) || returnValue <= minValue || returnValue > maxValue);
            return returnValue;
        }

    }
}
