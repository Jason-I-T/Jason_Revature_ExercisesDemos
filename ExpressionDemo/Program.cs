namespace ExpressionDemo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Using expression body in the constructor, IsPokemon(), 
        // and in the getter/setter for the name field.
        Pokemon p = new Pokemon("Pikachu");
        p.IsPokemon();

        Console.WriteLine(p.Name);
        p.Name = "NotPickachu";
        Console.WriteLine(p.Name);

        Console.WriteLine(p[0]);
        Console.WriteLine(p[1]);
        Console.WriteLine(p[2]);
        Console.WriteLine(p[3]);

        p[0] = 999;
        Console.WriteLine(p[0]);
    }
}
