using System.Data;

namespace PP_oppgave_uke_4;

public class Pets
{
    private string name = "";
    private int age = 0;
    private int hunger = 0;
    private int happiness = 0;
    private int natureCalls = 0;

    public Pets(string name)
    {
        this.name = name;
        age = 0;
        hunger = 5;
        happiness = 0;
        natureCalls = 0;
    }



    public static void run()
    {
        Console.WriteLine("Hvilket dyr vil du ta vare på?");
        Console.WriteLine("1. panda");
        Console.WriteLine("2. katt");
        Console.WriteLine("3. hund");

        var input = Console.ReadLine();
        var petname = "";

        while (true)
        {
            if (input == "1")
            {
                petname = "panda";
                Console.WriteLine($"du har valgt {petname}");
            }
            else if (input == "2")
            {
                petname = "katt";
                Console.WriteLine($"du har valgt {petname}");
            }
            else if (input == "3")
            {
                petname = "hund";
                Console.WriteLine($"du har valgt {petname}");
            }
            else
            {
                Console.WriteLine("ugyldig prøøv igjen");
                input = Console.ReadLine();
            }
            Console.Clear();
            Pets pet = new Pets(petname);


            while (true)
            {
                Console.WriteLine($"hva vil gjøre med {pet.name}?");
                Console.WriteLine($"1. gi {pet.name} mat");
                Console.WriteLine($"2. kos med {pet.name}");
                Console.WriteLine($"3. sjekk om {pet.name} må på do");

                input = Console.ReadLine();

                if (input == "1")
                {
                    pet.feed();
                }
                else if (input == "2")
                {
                    pet.play();
                }
                else if (input == "3")
                {
                    pet.piss();
                }
                else
                {
                    Console.WriteLine("ugyldig prøv igjen");
                    input = Console.ReadLine();
                }



            }




        }
    }

    private void piss()
    {
        if (natureCalls <= 0)
        {
            Console.WriteLine("Må ikke på do");
        }
        if (natureCalls >= 1)
        {
            Console.WriteLine($"{name} Går på do");
            natureCalls -= 5;
            happiness += 5;
            printInfo();
        }
    }

    private void play()
    {
        if (happiness <= 0)
        {
            Console.WriteLine("Orker ikke å leke");
        }
        if (happiness >= 1)
        {
            Console.WriteLine($"{name} leker");
            happiness -= 5;
            hunger += 5;
            printInfo();
        }
    }

    private void feed()
    {
        if (hunger <= 0)
        {
            Console.WriteLine("ikke sulten");
        }
        if (hunger >= 1) 
        { 
            Console.Clear();
            Console.WriteLine($"{name} spiser");
            hunger -= 5;
            natureCalls += 5;
            printInfo();

        }

    }
    private void printInfo()
    {
        Console.WriteLine($"Sult {hunger} ut av 10");
        Console.WriteLine($"Tissatrengt {natureCalls} ut av 10");
        Console.WriteLine($"Kjeder seg {happiness} ut av 10");
    }
}