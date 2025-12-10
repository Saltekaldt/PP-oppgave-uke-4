using System.Data;

namespace PP_oppgave_uke_4;

public class Pets
{
    private string name = "";
    private int age = 0;
    private int hunger = 0;
    private int happiness = 0;
    private int natureCalls = 0;
    private string petPicture = "";
    private Random rng = new Random();
    private int tall;

    public Pets(string name, string picture)
    {
        this.name = name;
        age = 0;
        hunger = 5;
        happiness = 0;
        natureCalls = 0;
        this.petPicture = picture;
    }



    public static void run()
    {
        Console.WriteLine("Hvilket dyr vil du ta vare på?");
        Console.WriteLine("1. panda");
        Console.WriteLine("2. katt");
        Console.WriteLine("3. hund");

        var input = Console.ReadLine();
        var petname = "";
        var petPicture = "";

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            if (input == "1")
            {
                petname = "panda";
                petPicture = @"
⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⢰⣿⡿⠗⠀⠠⠄⡀⠀⠀⠀⠀
⠀⠀⠀⠀⡜⠁⠀⠀⠀⠀⠀⠈⠑⢶⣶⡄
⢀⣶⣦⣸⠀⢼⣟⡇⠀⠀⢀⣀⠀⠘⡿⠃
⠀⢿⣿⣿⣄⠒⠀⠠⢶⡂⢫⣿⢇⢀⠃⠀
⠀⠈⠻⣿⣿⣿⣶⣤⣀⣀⣀⣂⡠⠊⠀⠀
⠀⠀⠀⠃⠀⠀⠉⠙⠛⠿⣿⣿⣧⠀⠀⠀
⠀⠀⠘⡀⠀⠀⠀⠀⠀⠀⠘⣿⣿⡇⠀⠀
⠀⠀⠀⣷⣄⡀⠀⠀⠀⢀⣴⡟⠿⠃⠀⠀
⠀⠀⠀⢻⣿⣿⠉⠉⢹⣿⣿⠁⠀⠀⠀⠀
⠀⠀⠀⠀⠉⠁⠀⠀⠀⠉⠁⠀⠀⠀⠀⠀
";
                Console.WriteLine($"du har valgt {petname}");
            }
            else if (input == "2")
            {
                petname = "katt";
                petPicture = @"
 _
( \
 \ \
 / /                |\\
/ /     .-`````-.   / ^`-.
\ \    /         \_/  {|} `o
 \ \  /   .---.   \\ _  ,--'
  \ \/   /     \,  \( `^^^
   \   \/\      (\  )
    \   ) \     ) \ \
     ) /__ \__  ) (\ \___
    (___)))__))(__))(__)))";
                Console.WriteLine($"du har valgt {petname}");
            }
            else if (input == "3")
            {
                petname = "hund";
                petPicture = @"           ___
       .-'`   `'-.
   _,.'.===   ===.'.,_
  / /  .___. .___.  \ \
 / /   ( o ) ( o )   \ \                                            _
: /|    '-'___'-'    |\ ;                                          (_)
| |`\_,.-'`   `""-.,_/'| |                                          /|
| |  \             /  | |                                         /\;
| |   \           /   | | _                              ___     /\/
| |    \   __    /\   | |' `\-.-.-.-.-.-.-.-.-.-.-.-.-./`   `""-,/\/ 
| |     \ (__)  /\ `-'| |    `\ \ \ \ \ \ \ \ \ \ \ \ \`\       \/
| |      \-...-/  `-,_| |      \`\ \ \ \ \ \ \ \ \ \ \ \ \       \
| |       '---'    /  | |       | | | | | | | | | | | | | |       |
| |               |   | |       | | | | | | | | | | | | | |       |
\_/               |   \_/       | | | | | | | | | | | | | | .--.  ;
                  |       .--.  | | | | | | | | | | | | | | |  | /
                   \      |  | / / / / / / / / / / / / / /  |  |/
                   |`-.___|  |/-'-'-'-'-'-'-'-'-'-'-'-'-'`--|  |
            ,.-----'~~;   |  |                  (_(_(______)|  |
           (_(_(_______)  |  |                        ,-----`~~~\
                    ,-----`~~~\                      (_(_(_______)";
                Console.WriteLine($"du har valgt {petname}");
            }
            else
            {
                Console.WriteLine("ugyldig prøøv igjen");
                input = Console.ReadLine();
            }
            Console.Clear();
            Pets pet = new Pets(petname, petPicture);


            while (true)
            {
                pet.random();
                if (pet.age >= 10)
                {
                    Console.Clear();
                    Console.WriteLine($"{pet.name} døde RIP");
                    run();
                }
                pet.printInfo();
                Console.WriteLine($"{pet.petPicture}");
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
        if (tall == 9)
        {
            Console.Clear();
            Console.WriteLine($"{name} falt ned i dass");
            run();
        }
        if (natureCalls <= 0)
        {
            Console.Clear();
            Console.WriteLine("Må ikke på do");
        }
        if (natureCalls >= 1)
        {
            Console.Clear();
            Console.WriteLine($"{name} Går på do");
            natureCalls -= 5;
            happiness += 5;
            age += 2;

        }
    }

    private void play()
    {
        if (tall == 2)
        {
            Console.Clear();
            Console.WriteLine($"{name} følgte ballen av en klippe");
            run();
        }
        if (happiness <= 0)
        {
            Console.Clear();
            Console.WriteLine("Orker ikke å leke");
        }
        if (happiness >= 1)
        {
            Console.Clear();
            Console.WriteLine($"{name} leker");
            happiness -= 5;
            hunger += 5;
            age += 2;

        }
    }

    private void feed()
    {
        if (tall == 4)
        {
            Console.Clear ();
            Console.WriteLine($"{name} kvelte seg");
            run();
        }
        if (hunger <= 0)
        {
            Console.Clear();
            Console.WriteLine("ikke sulten");
        }
        if (hunger >= 1)
        {
            Console.Clear();
            Console.WriteLine($"{name} spiser");
            hunger -= 5;
            natureCalls += 5;
            age += 2;

        }

    }
    private void printInfo()
    {
        Console.WriteLine($"Sult {hunger} ut av 10");
        Console.WriteLine($"Tissatrengt {natureCalls} ut av 10");
        Console.WriteLine($"Kjeder seg {happiness} ut av 10");
        Console.WriteLine($"{age}/10");
    }

    private void random()
    {
        tall = rng.Next(1, 11);
    }


}