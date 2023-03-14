namespace i41.Trash;

public enum TrashType
{
    Trash,
    Glass,
    Plastic,
    Organic,
    Paper,
    Food,
}

public static class TrashUtility
{
    public static TrashType Type(this Trash trash)
    {
        return trash switch
        {
            GlassTrash => TrashType.Glass,
            PlasticTrash => TrashType.Plastic,
            FoodTrash => TrashType.Food,
            PaperTrash => TrashType.Paper,
            OrganicTrash => TrashType.Organic,
            _ => TrashType.Trash
        };
    }
}