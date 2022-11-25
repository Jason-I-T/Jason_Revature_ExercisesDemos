using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using BusinessLayer;

namespace ApiUi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Pokemon : ControllerBase
    {
        //Datafield to hold reference of a BusinessLayerClass object
        private readonly IBusinessLayerClass _ibus;
        
        // Using constructor to pass a reference of a BusinessLayerClass object to the _ibus datafield
        public Pokemon(IBusinessLayerClass ibus){
            _ibus = ibus;
        }

        //model binding happens here.
        // The model binding system will look at all the properties of the json string 
        // and try to match them with the designated model
        [HttpPost("myguyishere")]
        public ActionResult<PokemonClass> PostPokemon(PokemonClass p)
        {
            // action methods (what this method is) are for routing to the correct busiess layet method. 
            // do as little manipulation as possible here.
            p.Name = "Marizard";
            PokemonClass p1 = _ibus.PostPokemon(p);

            return Created("mydb/pokemon/itshere", p1);
        }

    }
}