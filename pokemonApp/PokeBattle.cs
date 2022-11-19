namespace pokemonApp;
using System;
using System.Text.RegularExpressions;

public class PokeBattle {

    // user wins, return true. loss or run, return false. a=user b=computer
    public static bool Battle(Pokemon a, Pokemon b) {
        Random rand = new Random();
        int aHP = a.hp, bHP = b.hp;
        Console.WriteLine($"Started a battle between {a.name} and {b.name}!");
        
        int userMove = 0;
        do {
            Console.WriteLine($"Your HP: {aHP}\nEnemey HP: {bHP}");
            Console.WriteLine("Choose Move, Enter 1-4...RUN to flee\n");

            string? choice = Console.ReadLine();
            if(validateInput(choice)) {
                bool isMove = Int32.TryParse(choice, out userMove);
                if(!isMove) { return false; }
                --userMove;
            } else { continue; }

            Console.WriteLine();
            // Player doing damage to computer
            bHP -= DamageCalc(a, b, userMove);
            if(bHP <= 0) { return true; }

            // Computer doing damage to player
            int compMove = rand.Next(0,4);
            aHP -= DamageCalc(b, a, compMove);
            if(aHP <= 0) { return false; }
            Console.WriteLine();     
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
            Console.WriteLine("ERROR: invalid input (1-4, or RUN)");
            return false;
        }
    }

    // private void DamageCalc(hp, moves, move index, modifiers)
    private static int DamageCalc(Pokemon a, Pokemon b, int i) {
        // Calculating modifiers
        Random rand = new Random();
        int crit = CritCalc(rand, 10);

        // Modifiers to be used in damage expression
        int[] mod = {crit};

        // Damage expression
        int damage = a.moves[i] * mod[0];

        // Output giving feedback based off modifiers
        if (mod[0] > 1) 
            Console.WriteLine($"It's a critical hit! {a.name} did {damage} damage to {b.name}");
        else 
            Console.WriteLine($"{a.name} did {damage} damage to {b.name}");        

        return damage;
    }
}