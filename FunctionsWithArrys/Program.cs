using System;

namespace FunctionsWithArrys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string RandomColor = PickRandomColor(colors);
            Console.WriteLine($"Arvuti valis {RandomColor}.");
            DisplayRandomColor(colors);
        }
        private static int GenerateRandomNumberforArray(string[] someArray)
        {
            Random rnd = new Random();

            return rnd.Next(0, someArray.Length);

        }


        private static string PickRandomColor(string[] someArrays)
        {


            return someArrays[GenerateRandomNumberforArray(someArrays)];
        }


        private static void DisplayRandomColor(string[] someArray)
        {
           


            Console.WriteLine(someArray[GenerateRandomNumberforArray(someArray)]);


        }
    }
}
