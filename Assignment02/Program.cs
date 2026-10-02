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
            const string MaterialName = "Emerald";
            const double SmaltRate = 0.20;
            const double SalvageRate = 0.40;
            const double MaxBatch = 500;

            Console.WriteLine($"|| {MaterialName} Smelting {SmaltRate} Salvage {SalvageRate} ||");
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

            if (amountValid && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'T' || menu == 't')
                {
                    double ingot = amount * SmaltRate;
                    Console.WriteLine(" ---------------------------------------------");
                    Console.WriteLine($"  {amount:F2} {MaterialName} Shard = {ingot:F2} {MaterialName} Gem");
                    Console.WriteLine(" ---------------------------------------------");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double ore = amount / SalvageRate;
                    Console.WriteLine(" ---------------------------------------------");
                    Console.WriteLine($"  {amount:F2} {MaterialName} Gem = {ore:F2} {MaterialName} Shard");
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
            else if (amountValid && amount > MaxBatch)
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
