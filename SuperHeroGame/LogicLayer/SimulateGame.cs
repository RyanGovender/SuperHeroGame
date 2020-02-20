using SuperHeroGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroGame.LogicLayer
{
   public class SimulateGame
    {
        private Fighter _fighter1;
        private Fighter _fighter2;
        public int fighter1Count=0;
        public int fight2Count = 0;
        private int _maxRounds = 3;
        private int _attackType1 = 1;
        private int _attackType2 = 2;
        public SimulateGame(Fighter fighter1, Fighter fighter2 )
        {
            _fighter1 = fighter1;
            _fighter2 = fighter2;
        }

        public void PlayGame()
        {
            int input;
            int rounds = 0;
            do
            {
                ConsoleDisplay($"\n\n\t--------------- ROUND ({rounds+1}/3) --------- ");
                ConsoleDisplay(GetGameQuestions());
                input = int.Parse(Console.ReadLine());
                AttackType(input);
                ConsoleDisplay($"{_fighter1.Alias} :" +fighter1Count);
                ConsoleDisplay($"{_fighter2.Alias}" + fight2Count);
                rounds++;
            } while (rounds != _maxRounds);
        }

        public void AttackType(int attackType)
        {
           if(attackType == _attackType1)
            {
                CheckWinner(_fighter1.PhysicalStrength,_fighter2.PhysicalStrength);
            }
           else if(attackType == _attackType2)
            {
                CheckWinner(_fighter1.Speed, _fighter2.Speed);
            }
           else
            {
                CheckWinner(_fighter1.AttackPoints, _fighter2.AttackPoints);
            }
        }

        public bool CheckWinner(int fighter1,int fighter2)
        {
            var x = new Random();
            if (x.Next(0, fighter1)> x.Next(0, fighter2))
            {
                ConsoleDisplay(_fighter1.Alias + " has won this round");
                fighter1Count++;
                return true;
            }
            ConsoleDisplay(_fighter2.Alias + " has won this round");
            fight2Count++;
            return false;
        }
        public void CreateFighterCards()
        {
            CreateCard(_fighter1);
            ConsoleDisplay("\n VS \n");
            CreateCard(_fighter2);
        }

        public static void CreateCard(Fighter fighter)
        {
            
            Console.WriteLine($"\n\n{fighter.Alias}" +
                $"\n---------------------" +
                $"\n|                    |" +
                $"\n| Physical S : {fighter.PhysicalStrength}     |" +
                $"\n| Speed : {fighter.Speed}          |" +
                $"\n| Super Power : {fighter.AttackPoints}    |" +
                $"\n---------------------");
        }

        public string GetGameQuestions()
        {
            return "\t (0) - Do you want to use a Physical Strength Attack?" +
                "\n\t (1) - Do you want to use a Speed Attack ?" +
                "\n\t (2) - Do you want to user a Super Power Attack ?";
        }

        private void ConsoleDisplay(string message)
        {
          Console.WriteLine(message);
        }
    }
}
