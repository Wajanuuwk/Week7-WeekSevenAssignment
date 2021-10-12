using System;

namespace DuckSong
{
    class duck
    {
        static void Main(string[] args)
        {

            string Ducks;

            for (int i = 5; i > 0; i--)
            {
                if (i > 1)
                {
                    Ducks = "ducks";

                }
                else
                {
                    Ducks = "duck";
                }

                Console.WriteLine($"{i} little {Ducks} went out one day");
                Console.WriteLine("over the hill and far away");
                Console.WriteLine("mother duck said,\"Quack, quack, quack\"");

                if (i == 2)
                {
                    Ducks = "duck";
                }
                else if (i > 1)
                {
                    Console.WriteLine($"But only {i - 1} little {Ducks} came back");
                }
                else
                {
                    Console.WriteLine($"But none of the {i + 4} little ducks came back");
                }



            }
        }
    }
}