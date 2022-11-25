using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepoLayer
{
    //Creating interface to be used for dependency injection in BusinessLayerClass
    public interface IRepositoryClass
    {
        PokemonClass PostPokemon(PokemonClass p);
    }

    public class RepositoryClass : IRepositoryClass
    {
        //Datafield to hold reference of a MyLogger object
        private readonly IMyLogger _myLogger;
        
        // Using constructor to pass a reference of a MyLogger object to the _myLogger datafield
        public RepositoryClass(IMyLogger myLogger){
            _myLogger = myLogger;
        }
        public PokemonClass PostPokemon(PokemonClass p)
        {
            p.Dexterity = 100;
            if (File.Exists("PokemonList.json"))
            {
                string oldPlist = File.ReadAllText("PokemonList.json");

                // do the file saving
                List<PokemonClass> plist = JsonSerializer.Deserialize<List<PokemonClass>>(oldPlist)!;// the ! is to permanently denot tht I know it may be a null value

                plist.Add(p);

                string pliststr = JsonSerializer.Serialize(plist);

                File.WriteAllText("PokemonList.json", pliststr);
                _myLogger.LogStuff(p);
                return p;

            }
            else
            {
                List<PokemonClass> plist = new List<PokemonClass>();
                plist.Add(p);

                string pliststr = JsonSerializer.Serialize(plist);

                File.WriteAllText("PokemonList.json", pliststr);
                _myLogger.LogStuff(p);
                return p;
            }

        }
    }
}