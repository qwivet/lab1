namespace i41.Trash;

public class PlasticTrash : Trash
{
    public string Quality { get; }

    public PlasticTrash(float weight, float volume, string quality) : base(weight, volume)
    {
        Quality = quality;
    }
}