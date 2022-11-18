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
        int[] pikaMoves = {0, 15, 20, 25};
        int[] bulbaMoves = {1, 10, 15, 20};
        
        Pokemon pikachu = new Pokemon("Pikachu", 100, pikaMoves);
        Pokemon bulbasaur = new Pokemon("Bulbasaur", 100, bulbaMoves);

        Console.WriteLine(PokeBattle.Battle(pikachu, bulbasaur));
    }
}