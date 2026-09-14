namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==> BATTLE MAGE <==");
            Console.WriteLine("Hero vs. Monster -- Fight Calculator ");

            // User input of Hero stats
            Console.WriteLine("Hero Health: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            // User input of Monster stats
            Console.WriteLine("Monster Health: ");
            bool isMonHp = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Monster Attack: ");
            bool isMonAtk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Monster Defense: ");
            bool isMonDef = int.TryParse(Console.ReadLine(), out int monDef);

            // Check if player input is valid
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonsterValid = isMonHp && isMonAtk && isMonDef;
            Console.WriteLine($"Stats Validation: HERO: {allHeroValid}, MONSTER: {allMonsterValid}");
            Console.WriteLine($"[HERO]      HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]   HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");

            // Before fighting: Hero drinks a potion (Compound Assignment: +=)
            int potionHeal = 8;
            // 1. heroHp = heroHp + potionHeal;
            /*2.*/heroHp += potionHeal;// แนะนำแบบนี้ คำนวนเหมือนกับ 1 = 1+2
            Console.WriteLine($"\n=> Hero drinks a potion, Healing {potionHeal} HP. health is now: {heroHp}");

            // คำนวน damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");

            //คำนวน power attack (Predence ลำดับการคำนวน คูณ ก่อนที่จะลบ)
            int powerDamage = Math.Max(0, (heroAtk * 2) - monDef); //

            int CounterDamage = Math.Max(0, (monAtk * 2) - heroDef);
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            Random rng = new Random();
            int roll = rng.Next(1, 101);
            bool isCrit = roll <= 10;
            int criDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage;
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCrit}");
            Console.WriteLine($"Normal Attack would deal Critical: {criDamage} DMG");
        }
    }
}
