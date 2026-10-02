/*
* Student ID : 1690701501
* Name       : Assignment02
* Section    : 129B
* No.        : -
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string materialName = "Emerald";
            const double smaltRate = 0.20;
            const double salvageRate = 0.40;
            const double maxBatch = 500;

            Console.WriteLine($"|| {materialName} Smelting {smaltRate} Salvage {salvageRate} ||");
            Console.WriteLine("  _____________________________");
            Console.WriteLine(" /_|/_|/_|/_|/_/_|/_|/_|/_|/_|_|");
            Console.WriteLine("/_|/_|/_|/_|/_/_|/_|/_|/_|/_|/_|");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" |         [*]__[*]   ribbit   |");
            Console.WriteLine(" |        | -____- | /         |");
            Console.WriteLine(" |         l______|            |");
            Console.WriteLine(" |       ()[       ]()         |");
            Console.WriteLine(" ===============================");
            Console.WriteLine(" | * Welcome to Frog & Forge * |");
            Console.WriteLine(" -------------------------------");
            Console.WriteLine();

            Console.WriteLine(" =============     =============");
            Console.WriteLine(" |           |     |           |");
            Console.WriteLine(" |     T     |     |     B     |");
            Console.WriteLine(" |           |     |           |");
            Console.WriteLine(" =============     =============");
            Console.WriteLine(" Transmutation     Essence Break");
            Console.WriteLine(" (Shard -> Gem)    (Gem -> Shard)");
            Console.WriteLine();

            Console.Write("=> Choose Menu: "); 
            char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("=> How much would you like: ");
            bool  amountValid = double.TryParse(Console.ReadLine(), out double amount);
            Console.WriteLine();

            if (amountValid && amount > 0 && amount <= maxBatch)
            {
                if (menu == 'T' || menu == 't')
                {
                    double ingot = amount * smaltRate;
                    Console.WriteLine(" ---------------------------------------------");
                    Console.WriteLine($"  {amount:F2} {materialName} Shard = {ingot:F2} {materialName} Gem");
                    Console.WriteLine(" ---------------------------------------------");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double ore = amount / salvageRate;
                    Console.WriteLine(" ---------------------------------------------");
                    Console.WriteLine($"  {amount:F2} {materialName} Gem = {ore:F2} {materialName} Shard");
                    Console.WriteLine(" ---------------------------------------------");
                }
                else
                {
                    Console.WriteLine(" ----------------------------");
                    Console.WriteLine(" Oh, we don't have that menu.");
                    Console.WriteLine(" ----------------------------");
                }
            }
            else if (amountValid && amount <= 0)
            {
                Console.WriteLine(" ------------------------------------------------------");
                Console.WriteLine(" Sorry, but you don't have enough materials to make it");
                Console.WriteLine(" ------------------------------------------------------");
            }
            else if (amountValid && amount > maxBatch)
            {
                Console.WriteLine(" ---------------------------------------");
                Console.WriteLine(" Sorry, We don't craft that much at once");
                Console.WriteLine(" ---------------------------------------");
            }
            else
            {
                Console.WriteLine(" -------------------------------");
                Console.WriteLine(" Sorry, but What was the amount?");
                Console.WriteLine(" -------------------------------");
            }
        }
    }
}
