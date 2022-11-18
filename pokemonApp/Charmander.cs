namespace pokemonApp;

public class Charmander : Pokemon {
    public Charmander () {
        this.name = "Charmander";
        this.type = "Fire";
        this.hp = 100;
        int[] moves = {10, 20, 30 ,40};
        this.moves = moves;
    }

    public override void Sound() {
        Console.WriteLine("Charmander!");
    }
}