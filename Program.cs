// See https://aka.ms/new-console-template for more information
using JSONRead;
using Newtonsoft.Json;

Console.WriteLine("Started!");

var json = File.ReadAllText("users.json");
var dict = JsonConvert.DeserializeObject<List<UsersData>>(json);

foreach(var item in dict)
{
    Console.WriteLine("name ",item.Name);    
}

Console.WriteLine("Completed!");
