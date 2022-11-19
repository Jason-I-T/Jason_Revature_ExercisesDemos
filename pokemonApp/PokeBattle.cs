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
            if(validateInput(choice)) {
                if(choice.Equals("RUN")) { return false; }
                bool pleaseWork = Int32.TryParse(choice, out moveIndex);
            } else { continue; }

            // TODO: Make damage calculation its own method
            // private void DamageCalc(hp, moves, move index, modifiers)
            // User damage calculation
            int aCrit = CritCalc(critChance, 10);
            int[] modifiers = {aCrit};

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
        if (rand.Next(0, n) == 1) { modifier = 2; }
        return modifier;
    }

    // Returns true if user enters 1-4, or RUN
    private static bool validateInput(string input) {
        Regex moveCheck = new Regex(@"[1234]");
        Regex runCheck = new Regex(@"RUN");
        if(moveCheck.IsMatch(input) && input.Length == 1) {
            return true;      
        } else if(runCheck.IsMatch(input)) {
            Console.WriteLine("You have fleed the battle\n\n");
            return true;
        } else {
            Console.WriteLine("ERROR: invalid input (1-4, or RUN");
            return false;
        }
    }
}