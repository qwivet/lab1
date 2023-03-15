using System.Text.Json;

var numbers = new List<int>();
Console.WriteLine("Enter integers (for exit print 'e'):");
while (true)
{
    var t = Console.ReadLine();
    if (t == "e") break;
    if (!int.TryParse(t, out _)) throw new Exception("It isn't integer");
    numbers.Add(Convert.ToInt32(t));
}
Console.Write(JsonSerializer.Serialize(numbers.Where(n => n < 0 && n % 2 == 0).Reverse()));