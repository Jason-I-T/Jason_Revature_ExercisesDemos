using ConsumeApiDemo.obj;
using System.Text.Json;

namespace ConsumeApiDemo;
public class Program {
    static async Task Main(string[] args) {
        // Get response from API... get array of Item objects
        HttpClient client = new HttpClient();
        using HttpResponseMessage response = await client.GetAsync("https://mhw-db.com/items");
        string responseBody = await response.Content.ReadAsStringAsync();
        //Console.WriteLine(responseBody);

        // Create item object, deserialize the list of items, add the item. 
        // Show that the item was added successfully.
        //Item newItem = new Item();
        List<Item> dbItem = JsonSerializer.Deserialize<List<Item>>(responseBody)!;
        foreach(Item i in dbItem) {
            Console.WriteLine(i.name);
        }
    }
}
