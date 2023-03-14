namespace i41.Trash;

public abstract class OrganicTrash : Trash
{
    public float PercentOfOrganics { get; set; }

    protected OrganicTrash(float weight, float volume, float percentOfOrganics) : base(weight, volume)
    {
        PercentOfOrganics = percentOfOrganics;
    }
}