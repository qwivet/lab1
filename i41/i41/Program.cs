using System.Text.Json;
using i41;
using i41.Trash;

var trashes = new List<Trash>();
for (var i = 1; i <= 20; i++)
    trashes.Add(new PlasticTrash(i*.1f, 0.5f+i/10f, "high"));
for (var i = 1; i <= 20; i++)
    trashes.Add(new PaperTrash(3-i*.1f, 0.4f-i/100f, 0.6f, 2));
for (var i = 1; i <= 20; i++)
    trashes.Add(new FoodTrash(20%i+.1f, i, 0.9f, true));
for (var i = 1; i <= 20; i++)
    trashes.Add(new GlassTrash(2.0f, 0.7f, false));
var trashStation = new TrashStation(trashes);
Console.WriteLine(JsonSerializer.Serialize(trashStation.Trash).Replace(',', '\n'));
Console.WriteLine(JsonSerializer.Serialize(trashStation.VolumeSortedTrash).Replace(',', '\n'));
Console.WriteLine(JsonSerializer.Serialize(trashStation.WeightMoreThan(1)).Replace(',', '\n'));