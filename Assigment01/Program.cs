/*
* Student ID : 1690701501
* Name       : Lab02
* Section    : 129B
* No.        : -
* Course     : GI113 Computer Programming (GI)
*/

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=============== GAME INFORMATION ===============

            const string GameTitle = "HONEY BEAN FARM";

            //============= FARMER INFORMATION ===============

            var farmerName = "mina";
            var farmType = "A";
            int farmerLevel = 7;
            int maxFarmerLevel = 15;
            float cropBonus = 0.35f;
            double farmStamina = 87.5;
            bool isFarmOpen = true;

            double farmerLevelAsDouble = farmerLevel;
            int staminaTruncated = (int)farmStamina;
            int staminaRound = Convert.ToInt32(farmStamina);

            //================ FARM INFORMATION ===============

            string currentCrop = "Carrot";
            int cropCount = 13;
            int readyCropCount = 8;

            int wateringCan = 1;
            int hoe = 1;
            int fertilizer = 5;
            int seedCount = 12;

            //===================== TITLE =====================

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("   (_)     _____                    _____                _____                   (_)   ");
            Console.WriteLine("(_) 0 (_) |  |  |___ ___ ___ _ _   |  __ |___ ___ ___   |   __|___ ___ _____  (_) 0 (_)");
            Console.WriteLine(" (_)|(_)  |     | . |   | -_| | |  |  __-| -_| .'|   |  |   __| .'|  _|     |  (_)|(_) ");
            Console.WriteLine("    |     |__|__|___|_|_|___|_  |  |_____|___|__,|_|_|  |__|  |__,|_| |_|_|_|     |    ");
            Console.WriteLine("^^^^^^^^^                   |___|                                             ^^^^^^^^^");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=========================================================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                       PLANT      -      GROW      -      HARVEST                        ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=========================================================================================");

            //============== FARMER INFORMATION =================

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("o=================FARMER================o   o===================FARM====================o");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"| Name         : {farmerName,-22} |   | Current Crop on Farm : {currentCrop,-18} |");
            Console.WriteLine($"| Type         : {farmType,-22} |   | Crops : {cropCount,-33} |");
            Console.WriteLine($"| Level        : {farmerLevel} / {maxFarmerLevel,-19}|   | Ready To Harvest : {readyCropCount,-22} |   ");
            Console.WriteLine($"| Crop Bonus   : {cropBonus,-23}|   |                                           |");
            Console.WriteLine($"| Stamina      : {farmStamina,-23}|   |                                           |");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("o---------------------------------------o   o-------------------------------------------o");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("o=====================================INVENTORY=========================================o");
            Console.WriteLine("o---------------------------------------------------------------------------------------o");
            Console.WriteLine("|                   |  |                  |  |                   |  |                   |");
            Console.WriteLine("|                   |  |                  |  |                   |  |                   |");
            Console.WriteLine($"|  Watering can X{wateringCan}  |  |      Hoe X{hoe}      |  |   Fartilizer X{fertilizer}   |  |   CarrotSeed X{seedCount}  |");
            Console.WriteLine("|                   |  |                  |  |                   |  |                   |");
            Console.WriteLine("|                   |  |                  |  |                   |  |                   |");
            Console.WriteLine("o---------------------------------------------------------------------------------------o");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("o---------------------------------------------------------------------------------------o");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"| Stamina cast (truncates) : {staminaTruncated,-16}Stamina Convert (rounds) : {staminaRound,-15} |");
            Console.WriteLine($"| Level as double (implicit) : {farmerLevelAsDouble,-56} |");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("o---------------------------------------------------------------------------------------o");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
