using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroGame.Models
{
    public class Villian : Fighter
    {
        public bool VillainOrAnitHero { get; }
        public Villian(bool villainOrAntiHero ,int id, string name, string surname, string alias, string weakness, double lifepoints, int physical, int attack, int speed) : base(id, name, surname, alias, weakness, lifepoints, physical, attack, speed)
        {
          VillainOrAnitHero =  villainOrAntiHero;
        }
    }
}
