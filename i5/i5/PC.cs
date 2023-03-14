public class PC : Computer 
{
    public PC(float cost) : base(cost) {}
    public override void DisplayCost()
    {
        Console.WriteLine($"You spent {Cost} dollars to buy this PC");
    }
}