using System.Text.Json;

string[] numbers = {"-5", "6", "-3", "7", "-2", "0", "-8", "4"};
Console.Write(JsonSerializer.Serialize(numbers.Where(n => Convert.ToInt32(n) < 0 && Convert.ToInt32(n) % 2 == 0).Reverse()));