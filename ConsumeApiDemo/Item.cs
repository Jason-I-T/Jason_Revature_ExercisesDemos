using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumeApiDemo.obj;

public class Item {
    /*
    "id": int,
    "name": string,
    "description": string,
    "rarity": int, higher int more rare
    "carryLimit": int,
    "value": int
    */
    public int id {get; set;}
    public string ?name {get; set;}
    public string ?description {get; set;}
    public int rarity {get; set;}
    public int carryLimit {get; set;}
    public int value {get; set;}
}
