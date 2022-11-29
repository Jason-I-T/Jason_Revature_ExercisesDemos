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

    public Item() {}
    public Item(int id, string name, string description, int rarity, int carryLimit, int value) {
        this.id = id;
        this.name = name;
        this.description = description;
        this.rarity = rarity;
        this.carryLimit = carryLimit;
        this.value = value;
   
    }
}
