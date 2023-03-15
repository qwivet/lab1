public class Laptop : Computer, ICamera
{
    public Laptop(float cost) : base(cost) {}
    public override void DisplayCost()
    {
        Console.WriteLine($"Laptop cost is {Cost}");
    }

    public void MakeVideo()
    {
        Console.WriteLine("You try to make video on frontal camera of your laptop. Now you go to psychotherapist.");
    }

    public override void PlayGames()
    {
        Console.WriteLine("You try to play games.");
    }
}