namespace pokemonApp;

public class Raichu : Pikachu {

    public Raichu() {
        this.name = "Raichu";
        this.type = "Lightning";
        
        this.hp = base.hp + 20;
        int[] moves = new int[4];

        for(int i = 0; i < base.moves.Length; i++){
            moves[i] = base.moves[i] + 15;
        }

        this.moves = moves;
    }

    public override void Sound() {
        Console.WriteLine("Raichu!");
    }
}