namespace i41.Trash;

public abstract class Trash
{
    public float Weight { get; }
    public float Volume { get; }

    public Trash(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}