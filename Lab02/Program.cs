/*
 * Student ID : 1690701501
 * Name       : Lab02
 * Section    : 129B
 * No.        : -
 * Course     : GI113 Computer Programming (GI)
 */

using System;
using System.Xml.Linq;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Part A Lab 2
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            int hpPercent = currentHp * 100 / maxHp;

            Console.WriteLine();
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine($"Kirin takes 60 damage!");
            Console.WriteLine();

            currentHp = currentHp - 60;

            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            //Part B Lab 2
            string nameT = "Trevor";
            char classNameT = 'A';
            int maxRelationshipT = 10;
            int startRelationshipT = 0;
            int intelligenceT = 85;
            int artT = 80;
            int sportT = 75;
            double giftAffectionT = 0.10;
            float affectionRateT = 0.10f;
            bool isRomanceableT = true;

            Console.WriteLine($"===== ROMANCEABLE CHARACTER : TREVOR =====");
            Console.WriteLine($"Name: {nameT}");
            Console.WriteLine($"Class: {classNameT}");
            Console.WriteLine($"Relationship: {startRelationshipT} / {maxRelationshipT}");
            Console.WriteLine($"Intelligence: {intelligenceT}");
            Console.WriteLine($"Art: {artT}");
            Console.WriteLine($"Sport: {sportT}");
            Console.WriteLine();
            Console.WriteLine($"GiftAffection: {giftAffectionT}%");
            Console.WriteLine($"Affection: {affectionRateT}%");
            Console.WriteLine($"Romanceable: {isRomanceableT}");
            Console.WriteLine();

            string nameZ = "Zane";
            char classNameZ = 'C';
            int maxRelationshipZ = 10;
            int startRelationshipZ = 2;
            int intelligenceZ = 30;
            int artZ = 25;
            int sportZ = 95;
            double giftAffectionZ = 0.25;
            float affectionRateZ = 0.50f;
            bool isRomanceableZ = true;

            Console.WriteLine($"===== ROMANCEABLE CHARACTER : ZANE =====");
            Console.WriteLine($"Name: {nameZ}");
            Console.WriteLine($"Class: {classNameZ}");
            Console.WriteLine($"Relationship: {startRelationshipZ} / {maxRelationshipZ}");
            Console.WriteLine($"Intelligence: {intelligenceZ}");
            Console.WriteLine($"Art: {artZ}");
            Console.WriteLine($"Sport: {sportZ}");
            Console.WriteLine();
            Console.WriteLine($"GiftAffection: {giftAffectionZ}%");
            Console.WriteLine($"Affection: {affectionRateZ}%");
            Console.WriteLine($"Romanceable: {isRomanceableZ}");
            Console.WriteLine();

            string nameR = "Rey";
            char classNameR = 'A';
            int maxRelationshipR = 10;
            int startRelationshipR = 1;
            int intelligenceR = 95;
            int artR = 50;
            int sportR = 20;
            double giftAffectionR = 0.25;
            float affectionRateR = 0.20f;
            bool isRomanceableR = true;

            Console.WriteLine($"===== ROMANCEABLE CHARACTER : REY =====");
            Console.WriteLine($"Name: {nameR}");
            Console.WriteLine($"Class: {classNameR}");
            Console.WriteLine($"Relationship: {startRelationshipR} / {maxRelationshipR}");
            Console.WriteLine($"Intelligence: {intelligenceR}");
            Console.WriteLine($"Art: {artR}");
            Console.WriteLine($"Sport: {sportR}");
            Console.WriteLine();
            Console.WriteLine($"GiftAffection: {giftAffectionR}%");
            Console.WriteLine($"Affection: {affectionRateR}%");
            Console.WriteLine($"Romanceable: {isRomanceableR}");
            Console.WriteLine();

            string nameA = "Adrain";
            char classNameA = 'B';
            int maxRelationshipA = 10;
            int startRelationshipA = 0;
            int intelligenceA = 70;
            int artA = 85;
            int sportA = 45;
            double giftAffectionA = 0.50;
            float affectionRateA = 0.25f;
            bool isRomanceableA = true;

            Console.WriteLine($"===== ROMANCEABLE CHARACTER : ADRAIN =====");
            Console.WriteLine($"Name: {nameA}");
            Console.WriteLine($"Class: {classNameA}");
            Console.WriteLine($"Relationship: {startRelationshipA} / {maxRelationshipA}");
            Console.WriteLine($"Intelligence: {intelligenceA}");
            Console.WriteLine($"Art: {artA}");
            Console.WriteLine($"Sport: {sportA}");
            Console.WriteLine();
            Console.WriteLine($"GiftAffection: {giftAffectionA}%");
            Console.WriteLine($"Affection: {affectionRateA}%");
            Console.WriteLine($"Romanceable: {isRomanceableA}");
            Console.WriteLine();
        }
    }
}
