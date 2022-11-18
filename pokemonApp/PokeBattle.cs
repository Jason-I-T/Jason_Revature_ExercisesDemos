namespace pokemonApp;
using System;
using System.Text.RegularExpressions;

public class PokeBattle {

    /* Win - return true, Loss or Run - return false
       a - user, b - computer 
    */
    public static bool Battle(Pokemon a, Pokemon b) {
        Random rand = new Random();
        Random critChance = new Random();
        int aHP = a.hp, bHP = b.hp;
        Console.WriteLine($"Started battle between {a.name} and {b.name}!");
        

        int moveIndex = 0;
        do {

            Console.WriteLine($"Your HP: {aHP}\nEnemey HP: {bHP}");
            Console.WriteLine("Choose Move, Enter 1-4...RUN to flee\n");


            string? choice = Console.ReadLine();

            // TODO: Make validation and crit calculation its own methods...
            // if(choice.Equals("1") || choice.Equals("2") || choice.Equals("3") || choice.Equals("4") ) {
            //         bool pleaseWork = Int32.TryParse(choice, out moveIndex);
            // } else if(choice.Equals("RUN")) {
            //         Console.WriteLine("You have fleed the battle\n\n");
            //         return false;        
            // } 
            // else {
            //     Console.WriteLine("ERROR: invalid input");
            //     continue;
            // }
            if(validateInput(choice)) {
                if(choice.Equals("RUN")) { 
                        Console.WriteLine("You have fleed the battle\n\n");
                        return false; 
                    }
                bool pleaseWork = Int32.TryParse(choice, out moveIndex);
            }
            else {
                Console.WriteLine("ERROR: invalid input");
                continue;
            }

            // User damage calculation
            int aCrit = CritCalc(critChance, 10);
            bHP -= a.moves[--moveIndex] * aCrit;
            if (aCrit > 1) 
                Console.WriteLine($"\nIt's a critical hit! {a.name} did {a.moves[moveIndex]*aCrit} damage to {b.name}");
            else 
                Console.WriteLine($"\n{a.name} did {a.moves[moveIndex]} damange to {b.name}");

            // Enemey damage calculation
            int compChoice = rand.Next(0,4);
            int bCrit = CritCalc(critChance, 10);
            aHP -= b.moves[compChoice] * bCrit;
            if (bCrit > 1) 
                Console.WriteLine($"It's a critical hit! {b.name} did {b.moves[compChoice]*bCrit} damage to {a.name}\n");
            else 
                Console.WriteLine($"{b.name} did {b.moves[compChoice]} damange to {a.name}\n");

            if(aHP <= 0)
                return false; 
            if(bHP <= 0) 
                return true;

        } while(aHP > 0);
        
        return false;
    }

    // Take in random object... crit has 1 in n chance to happen... modifier will be included when we subtract health
    private static int CritCalc(Random rand, int n) { 
        int modifier = 1;
        if (rand.Next(0, n) == 1) { // is a crit
            modifier = 2;
        }

        return modifier;
    }

    private static bool validateInput(string input) {
        Regex re = new Regex(@"[1234]");
        if(re.IsMatch(input) && input.Length == 1) {
                    return true;      
            } 
            else {
                return false;
            }
    }
}