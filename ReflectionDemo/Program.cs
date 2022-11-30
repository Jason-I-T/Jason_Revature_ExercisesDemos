// Importing after referencing model layer in ApiStructureDemo
using ModelsLayer;

//Import the library
using System.Reflection;

namespace ReflectionDemo;
class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        PokemonClass p = new PokemonClass("Test", "grass", "red", 1, 1);
        PokemonClass p1 = new PokemonClass("NewTest", "fire", "green", 1, 1);
        // Type pokeClassType = typeof(PokemonClass);

        // MemberInfo[] pokeClassMemberInfo = pokeClassType.GetMembers();
        // for (int i =0 ; i < pokeClassMemberInfo.Length ; i++)
        //  {
        //     // Display name and type of the concerned member.
        //     Console.WriteLine( "'{0}' is a {1}", pokeClassMemberInfo[i].Name, pokeClassMemberInfo[i].MemberType);
        //  }

        // Console.WriteLine();

        // PropertyInfo[] pokeClassPropInfo = pokeClassType.GetProperties();
        // for(int i = 0; i < pokeClassPropInfo.Length; i++) {
        //     var pokeProp = pokeClassPropInfo[i];
        //     Console.WriteLine($"{pokeProp.Name} is a property with value {pokeProp.GetValue(p)} for {p.Name}");
        // }
        DisplayPokeInfo(p);
        DisplayPokeInfo(p1);
    }

    public static void DisplayPokeInfo(PokemonClass p) {
        Type pokeClassType = typeof(PokemonClass);

        MemberInfo[] pokeClassMemberInfo = pokeClassType.GetMembers();
        for (int i =0 ; i < pokeClassMemberInfo.Length ; i++)
         {
            // Display name and type of the concerned member.
            Console.WriteLine( "'{0}' is a {1}", pokeClassMemberInfo[i].Name, pokeClassMemberInfo[i].MemberType);
         }

        Console.WriteLine();

        PropertyInfo[] pokeClassPropInfo = pokeClassType.GetProperties();
        for(int i = 0; i < pokeClassPropInfo.Length; i++) {
            var pokeProp = pokeClassPropInfo[i];
            Console.WriteLine($"{pokeProp.Name} is a property with value {pokeProp.GetValue(p)} for {p.Name}");
        }
    }
}
