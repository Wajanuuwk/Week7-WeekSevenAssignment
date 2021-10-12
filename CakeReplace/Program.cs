using System;

namespace CakeReplace
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The cake is a lie");
            string thecake = Console.ReadLine();
            string fullname = $"{thecake}".ToLower();

            thecake = thecake.Replace('a', '4');
            thecake = thecake.Replace('i', '1');
            thecake = thecake.Replace('3', 's');
            Console.WriteLine(thecake);
        }
    }
}