namespace pokemonApp;

public class PokeBattle {
    public static string Battle(Pokemon a, Pokemon b) {
        Random rand = new Random();
        Random critChance = new Random();
        int aHP = a.hp, bHP = b.hp;
        bool crit = false; // if hit was a crit or not
        int critMult = 2; //crit multiplies damage by this x
        Console.WriteLine($"Started battle between {a.name} and {b.name}!");
        

        int moveIndex = 0;
        do {

            Console.WriteLine($"Your HP: {aHP}\nEnemey HP: {bHP}!");
            Console.WriteLine("Choose Move, Enter 1-4...");


            string? choice = Console.ReadLine();


            // if (choice.ToUpper().Equals("RUN")) return "You have fleed the battle";

            if(choice.Equals("1") || choice.Equals("2") || choice.Equals("3") || choice.Equals("4") ) {
                    bool pleaseWork = Int32.TryParse(choice, out moveIndex);
            } else {
                Console.WriteLine("Do it right this time (1-4)");
                continue;
            }

            // the user chose their move, now do damage
            if (critChance.Next(0,10) == 1) crit = true;  //randomly assigns if hit was a crit or not
            if (crit) {
                bHP -= a.moves[--moveIndex]*critMult;
                Console.WriteLine($"It's a critical hit! {a.name} did {a.moves[moveIndex]*critMult} damage to {b.name}");
            }
            else { 
            bHP -= a.moves[--moveIndex];
            Console.WriteLine($"{a.name} did {a.moves[moveIndex]} damange to {b.name}");
            }
            if(bHP <= 0) //if opponent dies
                return "You win!!";

            crit = false;
            if (critChance.Next(0,10) == 1) crit = true;
            int compChoice = rand.Next(0,4);
            
            //checks if hit was a critical strike or not
            if (crit) {
                aHP -= b.moves[compChoice]*critMult;
                Console.WriteLine($"It's a critical hit! {b.name} did {b.moves[compChoice]*critMult} damage to {a.name}");
            }

            else {
            aHP -= b.moves[compChoice];
            Console.WriteLine($"Enemy {b.name} did {b.moves[compChoice]} damage to {a.name}");
            }
            if(aHP <= 0)
                return "You lose!!"; 
            crit = false;
        } while(aHP > 0);
        
        return "";
    }
}