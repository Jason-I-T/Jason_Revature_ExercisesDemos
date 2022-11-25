using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoLayer
{
    // Logger Demo. Need to inject this logger into the class we want to log.
    // This logger injects into the RepositoryClass. And calls it in the PostPokemon method
    public interface IMyLogger {
        void LogStuff(object o);
    }

    // When creating interfaces, DONT FORGET TO INHERIT FROM THEM.
    public class MyLogger : IMyLogger
    {
        public void LogStuff(object o) {
            Console.WriteLine($"{o} just happened!");
        }
    }
}