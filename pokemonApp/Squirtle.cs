namespace pokemonApp;

public class Squirtle : Pokemon {

    public Squirtle () {
        this.name = "Squirtle";
        this.type = "Water";
        this.hp = 100;
        int[] moves = {10, 20, 30 ,40};
        this.moves = moves;
    }

    public override void Sound() {
        Console.WriteLine("Squirtle!");
    }
}