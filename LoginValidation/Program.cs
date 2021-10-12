using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;

        while (i < 3)
        {
            Console.WriteLine("Enter your username");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string userPass = Console.ReadLine();
            Console.WriteLine("Enter your PIN");
            string userPIN = Console.ReadLine();
            int pinLength = userPIN.Length;

            if (pinLength > 4)
            {
                Console.WriteLine("Wrong PIN. Try again.");
            }
            else
            {
                if (userName == "user1" && userPass == "password1" && userPIN == "1532")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Midagi läks valesti proovi uuesti {3 - i} proovi alles.");
                }
            }
        }
    }
}
