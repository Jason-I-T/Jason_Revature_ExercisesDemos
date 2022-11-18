namespace pokemonApp;

public class Bulbasaur : Pokemon {

    public Bulbasaur () {
        this.name = "Bulbasaur";
        this.type = "Grass";
        this.hp = 100;
        int[] moves = {10, 20, 30, 40};
        this.moves = moves;
    }

    public override void Sound() {
        Console.WriteLine("Bulbasaur!");
    }
}