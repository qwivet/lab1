namespace i41.Trash;

public class GlassTrash : Trash
{
    public bool IsBroken { get; }

    public GlassTrash(float weight, float volume, bool isBroken) : base(weight, volume)
    {
        IsBroken = isBroken;
    }
}