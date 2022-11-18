/*
Battle imp:
    battle loop - two pokemon
        array of moves, each entry int value for damage... multiplier maybe based on effectiveness
        user has choice of 1-4 , does damage to computer
        randomly choose move (1-4) for computer, does damange to user
        whoever hits 0 (or less) loses
        loop ends
*/

namespace pokemonApp;
class Program
{
    static void Main(string[] args)
    {
        //int[] pikaMoves = {0, 15, 20, 25};
        int[] bulbaMoves = {1, 10, 15, 20};

        Pokemon userPoke = new Pikachu();
        Pokemon cpuPokemon = new Bulbasaur();

        while(true) {
            bool win = PokeBattle.Battle(userPoke, cpuPokemon);
             if(win) {
                // evolve, go again
                Console.WriteLine("Congrats! You won...somethings happening...");
                string prevName = userPoke.name;
                userPoke = new Raichu();
                Console.WriteLine($"{prevName} evolved into {userPoke.name}");
             } else {
                Console.WriteLine("You lost!");
             }
             // CPU gets new pokemon
             // next iteration
        }

    }
}