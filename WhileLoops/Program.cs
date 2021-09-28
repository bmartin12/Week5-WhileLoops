using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            //kui sisestatud pin kood on 1234 siis konsool kuvab "tere tulemast"
            //kui sisestatud pin kood on midagi muud siis konsool kuvab "vale pin, proovi uuesti"
            //tingimus 1. katsete arv on piiramatu
            //tingimus 2. kasutajal on kolm katset
            //kasutajal on 3 katset

            //boolean = true/false
            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("sisesta PIN kood");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale PIN, {3 - i} proovi uuesti.");
                }

                
            }

            Console.WriteLine("kena päeva");
        }
    }
}
