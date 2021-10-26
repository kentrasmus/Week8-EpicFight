using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villan = PickVillan();
            int heroHP = GenerateHP(hero);
            int villianHP = GenerateHP(villan);

            Console.WriteLine($"{hero} will fight {villan}.");

            string heroWeapon = PickWeapon();
            string villansWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villan} picked {villansWeapon}");

            while(heroHP > 0 && villianHP > 0)
            {
                heroHP = heroHP - Hit(villan, hero, villansWeapon);
                villianHP = villianHP - Hit(hero, villan, heroWeapon);
            }
            if (heroHP <= 0)
            {
                Console.WriteLine("Dark side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }

        }
        private static int Hit(string characterOne, string characterTwo, string someWeapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, someWeapon.Length / 2);

            Console.WriteLine($"{characterOne} Hit {strike}.");
            if(strike == someWeapon.Length / 2)
            {
                Console.WriteLine($"Awesome! {characterOne} made a critical hit!");
            }
            else if (strike == 0)
            {
                Console.WriteLine($"{characterTwo} dodged the attack");
            }

            return strike;

        }


        private static int GenerateHP(string someName)
        {
            Random rnd = new Random();
            return rnd.Next(someName.Length, someName.Length + 10);
        }





        private static string PickWeapon()
        {
            string[] weapon = { "Fork", "banana", "apple", "Ur mom", "Wolf's Gravestone" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, weapon.Length);

            return weapon[randomIndex];

        }





        private static string PickHero()
        {
            string[] superHeros = { "Luke Skywalker", "Spiderman", "Batman", "Patric", "Lara Croft" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeros.Length);

            return superHeros[randomIndex];
        }
        private static string PickVillan()
        {
            string[] Villans = { "Death Vader", "Joker", "Voldemort", "T-1000", "Agent Smith" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Villans.Length);

            return Villans[randomIndex];
        }

    }
}
