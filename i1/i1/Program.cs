using System.Text.Json;

var list = new List<string>();
string t;
switch (Console.ReadLine())
{
    case "w":
        while (true)
        {
            Console.WriteLine("Write new element of list (print 'e' for end)");
            t = Console.ReadLine();
            if (t == "e")
                break;
            list.Add(t);
        }

        using (var sw = File.CreateText(@"C:\Users\User\Desktop\Prog\1\i\i1\list.json"))
            sw.Write(JsonSerializer.Serialize(list));
        break;
    case "rw":
        try
        {
            using (var sr = new StreamReader(@"C:\Users\User\Desktop\Prog\1\i\i1\list.json"))
                list = JsonSerializer.Deserialize<List<string>>(sr.ReadToEnd());
            list?.Reverse();
            using (var sw = File.CreateText(@"C:\Users\User\Desktop\Prog\1\i\i1\list.json"))
                sw.Write(JsonSerializer.Serialize(list));
        }
        catch
        {
            Console.WriteLine("File isn't correct");
        }
        break;
    default:
        Console.WriteLine("Isn't right command");
        break;
}