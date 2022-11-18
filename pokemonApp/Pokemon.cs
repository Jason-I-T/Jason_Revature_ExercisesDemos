namespace pokemonApp;

public class Pokemon 
{
    //Fields
    //Fields are private by default. This field was explicitly declared private.
    public string name {get; set;}
    public int hp {get; set;}
    public int[] moves {get; set;}
    int weight;
    int level;
    string type;
    
    Dictionary<string,int> moveList;

    //Auto-property syntax. This creates a backing field, along with the getter and setter.
    public int dexId {get; set;}

    public Pokemon() {}

    public Pokemon(string name)
    {
        this.name = name;
    }
    public Pokemon(string name, string type, int hp, int dexId, int weight, int level)
    {   
        this.name = name;
        this.type = type;
        this.hp = hp;
        this.dexId = dexId;
        this.weight = weight;
        this.level = level;
    }

    public Pokemon(string name, int hp, int[] moves) {
        this.name = name;
        this.hp = hp;
        this.moves = moves; // defined when pokemon is instantiated
    }

    //Methods
    //This method is an instance method. It can be called by an object of class Pokemon using dot-notation.
    public void IsPokemon()
    {
        Console.WriteLine($"My name is {name}. I'm a {type} I am a pokemon.");
    }

    //This method is static. It can be called with dot-notation using the name of the class itself.  
    public static void Sound() // Make this required to be overriden by child
    {
        Console.WriteLine("*pokemon noises*");
    }

    //Overriding
    public override string ToString()
    {
        Sound();
        return $"My name is {name}. I am a pokemon.";
    }
}