using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnus;
            //origrann küsib kasutajal sisestada parool;
            //programm kontrollib, kas mõlemad, nii kastajatunnus
            //kui ka parool on õiged;
            // kui mõlemad, kasutajatunnus ja parool on õiged
            //programm kuvab konsoolis "tere tulemast!"
            //kui kasutajatunnus või parool on vale, siis
            //programm kuvab "sisselogimine ebaõnnestus, proovi uuesti"
            //kt: admin, pr:admin1234
            //kasutajal on 3 katset

            int i = 0;
            
            while(i < 3)
            {
                Console.WriteLine("sisesta kasutaja tunnus");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta parool");
                string userPassword = Console.ReadLine();

                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("tere tulemast");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"proovi uuesti {3 - i} katset on jäänud");

                }
                Console.WriteLine("kena päeva");
            }
        }
    }
}
