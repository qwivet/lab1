using i41.Trash;

namespace i41;

public class TrashStation
{
    private readonly Dictionary<TrashType, List<Trash.Trash>> _trash;
    private readonly Dictionary<TrashType, List<Trash.Trash>> _volumeSortedTrash;

    public Dictionary<TrashType, List<Trash.Trash>> Trash { get => _trash; }
    public Dictionary<TrashType, List<Trash.Trash>> VolumeSortedTrash { get => _trash; }

    public TrashStation(List<Trash.Trash> trash)
    {
        _trash = new Dictionary<TrashType, List<Trash.Trash>>();
        foreach (var i in trash)
        {
            if(!_trash.ContainsKey(i.Type())) _trash.Add(i.Type(), new List<Trash.Trash>());
            _trash[i.Type()].Add(i);
        }
        _volumeSortedTrash = new Dictionary<TrashType, List<Trash.Trash>>();
        foreach (var i in _trash)
        {
            _volumeSortedTrash.Add(i.Key, i.Value.OrderBy(p => p.Volume).ToList());
        }
    }

    public Dictionary<TrashType, List<Trash.Trash>> WeightMoreThan(float weight)
    {
        var result = new Dictionary<TrashType, List<Trash.Trash>>();
        foreach (var i in _trash)
        {
            result.Add(i.Key, new List<Trash.Trash>());
            foreach (var j in i.Value.Where(j => j.Weight > weight))
                result[i.Key].Add(j);
        }

        return result;
    }
}