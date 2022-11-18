namespace pokemonApp;

public class Squirtle : Pokemon {

    public Squirtle (string name, string type, int hp, int[] moves) {
        base.name = name;
        base.type = type;
        base.hp = hp;
        base.moves = moves;
    }

    public override void Sound() {
        Console.WriteLine("Squirtle!");
    }
}