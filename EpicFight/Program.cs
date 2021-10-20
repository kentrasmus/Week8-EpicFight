using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string villan = PickVillan();
            Console.WriteLine($"{hero} will fight {villan}.");

            string heroWeapon = PickWeapon();
            string villansWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {villan} picked {villansWeapon}");
        }
        private static string PickWeapon()
        {
            string[] weapon = { "Fork", "banana", "apple", "Ur mom", "Wolf Gravestone" };
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
