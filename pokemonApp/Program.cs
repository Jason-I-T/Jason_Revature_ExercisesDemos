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
        //Object instantiation
        Pokemon charmander = new Pokemon("charmander");
        Pokemon squirtle = new Pokemon("squirtle");

        int[] pikaMoves = {0, 3, 4, 5};
        Pokemon pikachu = new Pokemon("Pikachu", 10, pikaMoves);
        int[] bulbaMoves = {1, 2, 3, 4};
        Pokemon bulbasaur = new Pokemon("Bulbasaur", 10, bulbaMoves);

        Console.WriteLine(Pokemon.Battle(pikachu, bulbasaur));
        
        //You can use dot notation to access fields and methods available to an object of that class.
        charmander.type = "fire";
        charmander.dexNumber = 4;
        Console.WriteLine(charmander.ToString());
        Console.WriteLine(squirtle.ToString());
        
        //This is how you call an instance method. It "belongs to" objects of that class.
        //You must instantiate an object of that class to call it.
        //charmander.IsPokemon();

        //This is how you call a Class/static method. It "belongs to" the class. You do not need 
        //to instantiate an object to call it. 
        //Pokemon.Sound();

    }
}

class Pokemon 
{
    //Fields
    //Fields are private by default. This field was explicitly declared private.
    private string name;
    
    //This field is public. It was explicitely declared public. It can be accessed via dot-notation
    //from any object of this class.
    public string type;
    
    //This field is also private. When no access modifier is explicitly given, the compiler treats the
    //field as private.
    int hitpoints;

    //Auto-property syntax. This creates a backing field, along with the getter and setter. 
    public int dexNumber {get; set;}
    
    int weight;
    int level;

    int[] moves = new int[4];

    //Constructors - Special methods used to instantiate or "create" an instance of a class.
    //You can have as many constructors as you need provided the signatures are different. 
    //This is a common example of method overloading. 
    public Pokemon()
    {

    }

    public Pokemon(string name)
    {
        this.name = name;
    }
    public Pokemon(string pokename, string type, int hp, int dex, int wt, int lvl)
    {   
        name = pokename;

        //When the name of a constructor argument and the name of a class field are the same,
        //"this.field" denotes the internal field, versus the argument that gets passed into the 
        //constructor
        this.type = type;
        hitpoints = hp;
        dexNumber = dex;
        weight = wt;
        level = lvl;
    }

    public Pokemon(string name, int hp, int[] moves) {
        this.name = name;
        hitpoints = hp;
        this.moves = moves; // defined when pokemon is instantiated
    }

    //Methods
    //This method is an instance method. It can be called by an object of class Pokemon using dot-notation.
    public void IsPokemon()
    {
        Console.WriteLine($"My name is {name}. I'm a {type} I am a pokemon.");
    }

    //This method is static. It can be called with dot-notation using the name of the class itself.  
    public static void Sound()
    {
        Console.WriteLine("*pokemon noises*");
    }

    public static string Battle(Pokemon a, Pokemon b) {
        Random rand = new Random();
        int aHP = a.hitpoints, bHP = b.hitpoints;
        
        Console.WriteLine($"Started battle between {a.name} and {b.name}!");
        

        int moveIndex = 0;
        do {
            Console.WriteLine($"Your HP: {aHP}\nEnemey HP: {bHP}!");
            Console.WriteLine("Choose Move, Enter 1-4...");
            string? choice = Console.ReadLine();
            if(choice.Equals("1") || choice.Equals("2") || choice.Equals("3") || choice.Equals("4") ) {
                    bool pleaseWork = Int32.TryParse(choice, out moveIndex);
            } else {
                Console.WriteLine("Do it right thsi time (1-4)");
                continue;
            }

            // the user chose their move, now do damage
            bHP -= a.moves[--moveIndex];
            Console.WriteLine($"You did {a.moves[moveIndex]} damange to {b.name}");
            if(bHP <= 0)
                return "You win!!";
            
            int compChoice = rand.Next(0,4);
            aHP -= b.moves[compChoice];
            Console.WriteLine($"Enemey did {b.moves[compChoice]} damange to {a.name}");
            if(aHP <= 0)
                return "You lose!!"; 

        } while(aHP > 0);
        return "";
    }

    //Overriding
    public override string ToString()
    {
        return $"My name is {name}, number {dexNumber}. I'm a {type} I am a pokemon.";
    }

}
