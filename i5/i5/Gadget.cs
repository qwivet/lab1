public abstract class Gadget 
{
    protected readonly float Cost;

    protected Gadget(float cost) {
        this.Cost = cost;
    }

    public abstract void DisplayCost();
}