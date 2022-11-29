using ConsumeApiDemo.obj;
using System.Text.Json;

namespace ConsumeApiDemo;
public class Program {
    static async Task Main(string[] args) {
        // Get response from API... API fetches array of Item objects
        HttpClient client = new HttpClient();
        using HttpResponseMessage response = await client.GetAsync("https://mhw-db.com/items");
        string responseBody = await response.Content.ReadAsStringAsync();
        //Console.WriteLine(responseBody);

        // Deserialize the list of items, Create item object add the item. 
        // Show that the item was added successfully.
        List<Item> dbItem = JsonSerializer.Deserialize<List<Item>>(responseBody)!;
        
        Item newItem = new Item{
            id = dbItem[dbItem.Count()-1].id + 1,
            name = "MyItem",
            description = "For fun :)",
            rarity = 11,
            carryLimit = 0,
            value = 10    
        };
        dbItem.Add(newItem);

        foreach(Item i in dbItem) Console.WriteLine($"{i.name}, {i.description}\n");

        string jsonDbItem = JsonSerializer.Serialize(dbItem);
        File.WriteAllText("MHWItems.json", jsonDbItem);
    }
}
