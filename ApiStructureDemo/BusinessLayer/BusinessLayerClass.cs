using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

/**
The business layer is used for manipulating data, creating mondels, etc.. that can be sent to the 
repo layer and returned to the UI layer.
*/
namespace BusinessLayer
{
    // Interface for dependency injection in the Pokemon controller class
    public interface IBusinessLayerClass
    {
        PokemonClass PostPokemon(PokemonClass p);
    }

    public class BusinessLayerClass : IBusinessLayerClass
    {
        //Datafield to hold reference of a RepositoryClass object
        private readonly IRepositoryClass _repo;
        
        // Using constructor to pass a reference of a RepositoryClass object to the _repo datafield
        public BusinessLayerClass(IRepositoryClass repo){
            _repo = repo;
        }
        public PokemonClass PostPokemon(PokemonClass p)
        {
            p.Color = "blue";
            PokemonClass p1 = _repo.PostPokemon(p);
            return p1;

        }
    }
}