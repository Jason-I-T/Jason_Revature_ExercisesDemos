/*
Battle:
    battle loop - two pokemon
        array of moves, each entry int value for damage... multiplier maybe based on effectiveness
        user has choice of 1-4 , does damage to computer
        randomly choose move (1-4) for computer, does damange to user
        whoever hits 0 (or less) loses
        loop ends
*/
using System.Text.Json;

namespace pokemonApp;
class Program
{
    static void Main(string[] args)
    {
        //string name, string type, int hp, int dexId, int weight, int level
        Pokemon charmander = new Pokemon {
            name = "charmander",
            type = "fire",
            hp = 10,
            dexId = 4,
            weight = 10,
            level = 1
        };
        
        // Serializing
        string jsonString = JsonSerializer.Serialize(charmander);
        File.WriteAllText("test.json", jsonString);
        Console.WriteLine(File.ReadAllText("test.json"));
        
        // Deserializing 
        jsonString = File.ReadAllText("test.json");
        Pokemon charmander2 = JsonSerializer.Deserialize<Pokemon>(jsonString)!;
        Console.WriteLine($"I'm a deserialized {charmander2.name}");
        
        
        
        
        // Pokemon userPoke = new Pikachu();
        // Pokemon cpuPokemon = new Bulbasaur();

        // while(true) {
        //     bool win = PokeBattle.Battle(userPoke, cpuPokemon);
        //     if(win) {
        //         // evolve, go again
        //         Console.WriteLine("Congrats! You won...somethings happening...");
        //         string prevName = userPoke.name;
        //         userPoke = new Raichu();
        //         Console.WriteLine($"{prevName} evolved into {userPoke.name}");
        //     } else { Console.WriteLine("You lost!"); }

        //     Console.WriteLine("Press enter to continue, or type something to exit...");
        //     string cont = Console.ReadLine();
        //     if(cont.Length > 0) { break; }
        // }
    }
}