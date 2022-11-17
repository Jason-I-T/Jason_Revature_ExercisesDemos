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

        int[] pikaMoves = {0, 15, 20, 25};
        Pokemon pikachu = new Pokemon("Pikachu", 100, pikaMoves);
        int[] bulbaMoves = {1, 10, 15, 20};
        Pokemon bulbasaur = new Pokemon("Bulbasaur", 100, bulbaMoves);

        Console.WriteLine(Pokemon.Battle(pikachu, bulbasaur));
        
        //You can use dot notation to access fields and methods available to an object of that class.
        charmander.type = "fire";
        charmander.dexNumber = 4;
      //  Console.WriteLine(charmander.ToString());
      //  Console.WriteLine(squirtle.ToString());
        
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
    Dictionary<string,int> moveList;

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
     public Pokemon(string name, int hp, Dictionary<string,int> moveList) {
        this.name = name;
        hitpoints = hp;
        this.moveList = moveList; // defined when pokemon is instantiated
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
        Random critChance = new Random();
        int aHP = a.hitpoints, bHP = b.hitpoints;
        bool crit = false; // if hit was a crit or not
        int critMult = 2; //crit multiplies damage by this x
        Console.WriteLine($"Started battle between {a.name} and {b.name}!");
        

        int moveIndex = 0;
        do {

            Console.WriteLine($"Your HP: {aHP}\nEnemey HP: {bHP}!");
            Console.WriteLine("Choose Move, Enter 1-4...");


            string? choice = Console.ReadLine();


         // if (choice.ToUpper().Equals("RUN")) return "You have fleed the battle";

            if(choice.Equals("1") || choice.Equals("2") || choice.Equals("3") || choice.Equals("4") ) {
                    bool pleaseWork = Int32.TryParse(choice, out moveIndex);
            } else {
                Console.WriteLine("Do it right this time (1-4)");
                continue;
            }

            // the user chose their move, now do damage
            if (critChance.Next(0,10) == 1) crit = true;  //randomly assigns if hit was a crit or not
            if (crit) {
                bHP -= a.moves[--moveIndex]*critMult;
                Console.WriteLine($"It's a critical hit! {a.name} did {a.moves[moveIndex]*critMult} damage to {b.name}");
            }
           else { 
            bHP -= a.moves[--moveIndex];
            Console.WriteLine($"{a.name} did {a.moves[moveIndex]} damange to {b.name}");
           }
            if(bHP <= 0) //if opponent dies
                return "You win!!";

            crit = false;
            if (critChance.Next(0,10) == 1) crit = true;
            int compChoice = rand.Next(0,4);
            
            //checks if hit was a critical strike or not
         if (crit) {
                aHP -= b.moves[compChoice]*critMult;
                Console.WriteLine($"It's a critical hit! {b.name} did {b.moves[compChoice]*critMult} damage to {a.name}");
            }

            else {
            aHP -= b.moves[compChoice];
            Console.WriteLine($"Enemy {b.name} did {b.moves[compChoice]} damage to {a.name}");
            }
            if(aHP <= 0)
                return "You lose!!"; 
        crit = false;

        } while(aHP > 0);
        return "";
    }

    //Overriding
    public override string ToString()
    {
        return $"My name is {name}, number {dexNumber}. I'm a {type} I am a pokemon.";
    }

}
