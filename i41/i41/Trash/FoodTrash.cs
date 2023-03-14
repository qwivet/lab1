namespace i41.Trash;

public class FoodTrash : OrganicTrash
{
    public bool CanPoison { get; }

    public FoodTrash(float weight, float volume, float percentOfOrganics, bool canPoison) : base(weight, volume, percentOfOrganics)
    {
        CanPoison = canPoison;
    }
}