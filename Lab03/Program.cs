/*
* Student ID : 1690701501
* Name       : Lab03
* Section    : 129B
* No.        : -
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Boss Stats
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"level: {level} / {MaxLevel}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit miltiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            // Implicit conversion HP (int) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // Calcuate Percent as double
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Peercent (exact): {hpPercentExact}%");

            // Explicit casting attack power (float) -->> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackDisplay = (int)attackPower;
            Console.WriteLine($"Attack Powwer (int cast): {attackDisplay}");

            // Cast vs. Convert: Crit Multiplier
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}
