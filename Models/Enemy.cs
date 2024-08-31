using System;
using System.Threading.Tasks;

namespace BlazorDex.Models
{
    public class Enemy
    {
        public int Hp { get; set; }
        public int Speed { get; set; }
        public int Armor { get; set; }
        public int Dmg { get; set; }
        public string Name { get; set; }
        public string SceneUrl { get; set; }
        public string AttackUrl { get; set; }
        public string StandUrl { get; set; }
        public string DefendUrl { get; set; }
        public string BoostUrl { get; set; }
        public string IconUrl { get; set; }
        public int ExperienceProvided { get; set; }
        public int PointsProvided { get; set; }
        public int NumberOfSpells { get; set; }


        public Func<int, int, int, GameAnimationService, Func<string, Task>, Action<bool, string>, Task> AttackAbility { get; set; }

        public Enemy(int hp, int speed, int armor, int dmg, string name, string sceneUrl, string attackUrl, string standUrl, string defendUrl, string boostUrl, string iconUrl, int pointsProvided, int experienceProvided, int numberOfSpells)
        {
            Hp = hp;
            Speed = speed;
            Armor = armor;
            Dmg = dmg;
            Name = name;
            SceneUrl = sceneUrl;
            AttackUrl = attackUrl;
            StandUrl = standUrl;
            DefendUrl = defendUrl;
            BoostUrl = boostUrl;
            IconUrl = iconUrl;
            PointsProvided = pointsProvided;
            ExperienceProvided = experienceProvided;
            NumberOfSpells = numberOfSpells;
        }
    }
}
