namespace i41.Trash;

public class PaperTrash : OrganicTrash
{
    public int Stage { get; }

    public PaperTrash(float weight, float volume, float percentOfOrganics, int stage) : base(weight, volume, percentOfOrganics)
    {
        Stage = stage;
    }
}