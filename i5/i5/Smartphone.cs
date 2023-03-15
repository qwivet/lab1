public abstract class Smartphone : Gadget 
{
    protected Smartphone(float cost) : base(cost) {}
    
    public override void DisplayCost() 
    {
        Console.WriteLine($"The cost of this smartphone is ${Cost}");
    }

    public abstract void MakeCall();
}