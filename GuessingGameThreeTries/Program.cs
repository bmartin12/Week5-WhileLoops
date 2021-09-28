using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset kui kasutaja ei ole suutnud kolme katsega numbrit ära
            //programm genereerib juhulikku numbrit ühte korda
            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            int i = 0;
            
            while (1 < 3)
            {
                Console.WriteLine("sisesta number");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                
                if (cpuRandom == userGuess)
                {
                    Console.WriteLine("good job mate");
                    break;
                }
                else
                {
                    i++; //i = i + 1
                    Console.WriteLine($"try again {3 - i} tries left");
                }
            }

            if(i == 3)
            {
                Console.WriteLine("ye lost :(");
            }
            

        }
    }
}
