/*
* Student ID : 1690701501
* Name       : Lab02
* Section    : 129B
* No.        : -
* Course     : GI113 Computer Programming (GI)
*/

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ================= FINAL BATTLE ==================

            Console.WriteLine("================== FINAL BATTLE =================");
            Console.WriteLine("You have been fighting the monster for many deys");
            Console.WriteLine("  You are need to rest before the final battle");
            Console.WriteLine("=================================================");
            Console.WriteLine();

            int heroHp = 50;
            int monsterHp = 120;
            int heroAttack = 50;
            int monsterAttack = 50;

            Console.Write("How many days will you rest? (1-7): ");
            bool restInputOk = int.TryParse(Console.ReadLine(), out int restDays);

            if (!restInputOk || restDays < 1 || restDays > 7)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
            }
            else if (restDays >= 1 && restDays <= 3)
            {
                Console.WriteLine();
                Console.WriteLine($"You rest for {restDays} days.");
                Console.WriteLine("You are still tired");
                Console.WriteLine($"Your HP remains at {heroHp}.");

                Console.WriteLine();
                Console.WriteLine("===== Choose your action =====");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Negotiate");
                Console.WriteLine("3. Escap");
                Console.WriteLine();

                Console.WriteLine("Your choice: ");
                bool inputOk = int.TryParse(Console.ReadLine(), out int choice);

                if (!inputOk)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter 1, 2 or 3.");
                }
                else if (choice == 1)
                {
                    monsterHp -= heroAttack;
                    heroHp -= monsterAttack;
                    Console.WriteLine();
                    Console.WriteLine("========== You atteck monster ==========");
                    Console.WriteLine();
                    Console.WriteLine($"You deal {heroAttack} damage Monster HP is now {monsterHp}");
                    Console.WriteLine();
                    Console.WriteLine("!!!!!-The monster attacks you back-!!!!!");
                    Console.WriteLine();

                    if (heroHp <= 0)
                    {
                        heroHp = heroHp - monsterAttack;

                        Console.WriteLine($"========= You take {monsterAttack} damage. =========");
                        Console.WriteLine();
                        Console.WriteLine($"        Hero HP is now {heroHp}.");
                        Console.WriteLine("       You have been defeated");
                        Console.WriteLine();
                        Console.WriteLine("==== ENDING 1 Died a wretched death ====");
                    }
                    else
                    {
                        Console.WriteLine($"===== You take {monsterAttack} damage. =====");
                        Console.WriteLine();
                        Console.WriteLine($"Hero HP is now {heroHp}.");
                        Console.WriteLine("You survive the attack.");
                        Console.WriteLine("It’s really fortunate that you got some proper rest before continuing your journey.");
                        Console.WriteLine();
                        Console.WriteLine("===== ENDING 2 Survived because of caution. =====");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("You try to negotiate with the monster.");
                    Console.WriteLine("It turned out this monster didn't like violence either");
                    Console.WriteLine("So, you and the monster shook hands before parting ways to go home.");
                    Console.WriteLine();
                    Console.WriteLine("===== ENDING 3 Made it home safely =====");
                }
                else if (choice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("You decide to escape.");
                    Console.WriteLine("You successfully escape from the battlefield.");
                    Console.WriteLine();
                    Console.WriteLine("===== ENDING 4 A bit cowardly, but safe.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter 1, 2 or 3.");
                }
            }
            else
            {
                heroHp = 100;
                Console.WriteLine();
                Console.WriteLine($"You rest for {restDays} days.");
                Console.WriteLine("You feel fully rested and ready for the final battle.");
                Console.WriteLine($"Your HP increased to {heroHp}.");

                Console.WriteLine();
                Console.WriteLine("===== Choose your action =====");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Negotiate");
                Console.WriteLine("3. Escap");
                Console.WriteLine();

                Console.WriteLine("Your choice: ");
                bool inputOk = int.TryParse(Console.ReadLine(), out int choice);

                if (!inputOk)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter 1, 2 or 3.");
                }
                else if (choice == 1)
                {
                    monsterHp -= heroAttack;
                    heroHp -= monsterAttack;
                    Console.WriteLine();
                    Console.WriteLine("========== You atteck monster ==========");
                    Console.WriteLine($"You deal {heroAttack} damage Monster HP is now {monsterHp}");
                    Console.WriteLine();
                    Console.WriteLine("!!!!!-The monster attacks you back-!!!!!");
                    Console.WriteLine();

                    if (heroHp <= 0)
                    {
                        heroHp = heroHp - monsterAttack;

                        Console.WriteLine($"=====You take {monsterAttack} damage.=====");
                        Console.WriteLine();
                        Console.WriteLine($"        Hero HP is now {heroHp}.");
                        Console.WriteLine("         You have been defeated");
                        Console.WriteLine();
                        Console.WriteLine("===== ENDING 1 Died a wretched death =====");
                    }
                    else
                    {
                        Console.WriteLine($"=====You take {monsterAttack} damage.=====");
                        Console.WriteLine();
                        Console.WriteLine($"Hero HP is now {heroHp}.");
                        Console.WriteLine("You survive the attack.");
                        Console.WriteLine("It’s really fortunate that you got some proper rest before continuing your journey.");
                        Console.WriteLine();
                        Console.WriteLine("===== ENDING 2 Survived because of caution. =====");
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("=====You try to negotiate with the monster.=====");
                    Console.WriteLine("It turned out this monster didn't like violence either");
                    Console.WriteLine("So, you and the monster shook hands before parting ways to go home.");
                    Console.WriteLine();
                    Console.WriteLine("===== ENDING 3 Made it home safely =====");
                }
                else if (choice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("=====You decide to escape.=====");
                    Console.WriteLine("You successfully escape from the battlefield.");
                    Console.WriteLine();
                    Console.WriteLine("===== ENDING 4 A bit cowardly, but safe.=====");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter 1, 2 or 3.");
                }
            }
        }
    }
}
