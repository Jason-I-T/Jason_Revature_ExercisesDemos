namespace pokemonApp;

public class Pikachu : Pokemon {
     
    //"Pikachu", "Lightning", 100, pikaMoves
    public Pikachu() {
        this.name = "Pikachu";
        this.type = "Lightning";
        this.hp = 100;
        int[] moves = {100, 20, 30 ,40};
        this.moves = moves;
    }

    public override void Sound() {
        Console.WriteLine("Pika!");
    }
}