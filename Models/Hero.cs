namespace BlazorDex.Models
{
    public class Hero
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Hp { get; set; }
        public int Dmg { get; set; }
        public int Armor { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public int Points { get; set; }
        public int Exp { get; set; }
        public int ExpThreshold { get; set; }
        public int HeavyCrashLevel { get; set; }
        public int TearHealLevel { get; set; }
        public int MilkRegeLevel { get; set; }
        public int HeavyCrashDmg { get; set; }
        public int TearHealHp { get; set; }
        public int MilkRegeStats { get; set; }
        public int Wins { get; set; }



        // New Property to link Hero to a user
        public string? UserId { get; set; }
        public string? UserPin { get; set; }
    }

}
