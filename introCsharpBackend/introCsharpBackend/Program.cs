
using System.Text.Json;

var gilbert = new People()
{
    Name = "Gilbert",
    Age = 28
};

string json = JsonSerializer.Serialize(gilbert);

Console.WriteLine(json);

string myJson = @"
{
    ""Name"":""Roberto"",
    ""Age"":28
}
";

People roberto = JsonSerializer.Deserialize<People>(myJson);
Console.WriteLine(roberto?.Name);
Console.WriteLine(roberto?.Age);

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}