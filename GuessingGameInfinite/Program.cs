using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piirmatu
            //programm genereerib juhulikku numbrit ühte korda
            GetAppInfo();
            GreetUser();
            while (true)
            {
                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 11);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("are you dumb? i said guess a NUMBER");
                        Console.ResetColor();

                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again");
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That was the correct number, good job");
                Console.ResetColor();

                Console.WriteLine("wanna play again? y/n");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.69";
            string appAuthor = "swaggin";

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("Whats yer name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, wanna play a game?", inputName);
        }
    

    }
}
