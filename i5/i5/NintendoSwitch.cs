public class NintendoSwitch : Gadget 
{
    public NintendoSwitch(float cost) : base(cost) {}
    
    public override void DisplayCost() {
        Console.WriteLine($"You spent {Cost} to buy Switch");
    }
}