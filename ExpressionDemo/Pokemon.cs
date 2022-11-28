namespace ExpressionDemo;

/*
TODO: 
*Have a party of pokemon
    need derived class of pokemon (3 diff)
    put 3 in list
*Choose which pokemon to use
*The pokemon that wins, evolves
*/

public class Pokemon 
{
    //Fields
    //Fields are private by default. This field was explicitly declared private.
    
    //public string name {get; set;}
    // Private field, accessed with method implementing an expression body
    private string name; 

    // Private field, accessed with expression body (indexer example)
    private int[] moves = {10, 20, 30, 40};
    public int hp {get; set;}
    
    public int weight {get; set;}
    public int level {get; set;}
    public string type {get; set;}
    
    Dictionary<string,int> moveList;

    //Auto-property syntax. This creates a backing field, along with the getter and setter.
    public int dexId {get; set;}

    public Pokemon() {}

    //[access-modifier] ClassName([parameters]) => expression;
    // public Pokemon(string name)
    // {
    //     this.name = name;
    // }
    // Expression-bodied Constructor
    public Pokemon(string name) => this.name = name;

    public Pokemon(string name, string type, int hp, int dexId, int weight, int level)
    {   
        this.name = name;
        this.type = type;
        this.hp = hp;
        this.dexId = dexId;
        this.weight = weight;
        this.level = level;
    }

    // Getter and Setter for name field using expression body
    public string Name {
        get => name;
        set => name = value;
    }

    // Expression-Bodied Void Method
    public void IsPokemon() => Console.WriteLine($"My name is {name}. I am a pokemon.");
    // public void IsPokemon() 
    // {
    //     Console.WriteLine($"My name is {name}. I'm a {type} I am a pokemon.");
    // }

    // Expression-bodied Indexers. Normally readonly, changes it to Read/Write when we specify getters / setters
    // Indexer allows us to reference the private moves field using the pokemon object 
    public int this[int idx] {
        get => moves[idx];
        set => moves[idx] = value;
    } 
}