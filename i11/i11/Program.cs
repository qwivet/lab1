using System.Text.Json;

var d1 = new Dictionary<char, int>{{'a',100},{'b',200},{'c',300}};
var d2 = new Dictionary<char, int>{{'a',300},{'b',200},{'d',400}};
foreach (var i in d2)
    if (d1.ContainsKey(i.Key))
        d1[i.Key] += i.Value;
    else
        d1.Add(i.Key, i.Value);
using (var sw = File.CreateText(@"C:\Users\User\Desktop\Prog\1\i\i11\dict.txt"))
    sw.Write(JsonSerializer.Serialize(d1));
