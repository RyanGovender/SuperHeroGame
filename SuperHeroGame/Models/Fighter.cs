using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroGame.Models
{
    public abstract class Fighter
    {
        public int FighterId { get;}
        public string Name { get;}
        public string Surname { get;}
        public string Alias { get; }
        public int PhysicalStrength { get; }
        public int AttackPoints { get; }
        public int Speed { get; }

        public Fighter(int id,string name,string surname,string alias,string weakness,double lifepoints,int physical,int attack,int speed)
        {
            FighterId = id;
            Name = name;
            Surname = surname;
            Alias = alias;
            PhysicalStrength = physical;
            AttackPoints = attack;
            Speed = speed;
        }

        public virtual void DisplayFighterStats() {
            Console.WriteLine($"Name : {Name} {Surname}" +
                $"\nAlias : {Alias}" +
                $"\nPhysical Strength : {PhysicalStrength}/10" +
                $"\nAttack Points : {AttackPoints}/10" +
                $"\nSpeed : {Speed}/10");
        }
    }
}
