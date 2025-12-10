namespace PP_oppgave_uke_4;

public class Pets
{
    private string name = "";
    private int age = 0;
    private int hunger = 0;
    private int happiness = 0;


    public Pets(string name)
    {
        this.name = name;
        age = 0;
        hunger = 0;
        happiness = 0;
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
                    feed();
                }
                else if (input == "2")
                {
                    play();
                }
                else if (input == "3")
                {
                    piss();
                }
                else
                {
                    Console.WriteLine("ugyldig prøv igjen");
                    input = Console.ReadLine();
                }



            }




        }
    }

    private static void piss()
    {
        throw new NotImplementedException();
    }

    private static void play()
    {
        throw new NotImplementedException();
    }

    private static void feed()
    {
        throw new NotImplementedException();
    }
}