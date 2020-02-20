using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroGame.Models
{
    public class SuperHero : Fighter
    {
        public string SuperPower { get;}
        public SuperHero(string superPower, int id, string name, string surname, string alias, string weakness, double lifepoints, int physical, int attack, int speed) : base(id, name, surname, alias, weakness, lifepoints, physical, attack, speed)
        {
            SuperPower = superPower;
        }

        public override void DisplayFighterStats()
        {
            base.DisplayFighterStats();
            Console.WriteLine($"Super Power : {SuperPower}");
        }
    }
}
