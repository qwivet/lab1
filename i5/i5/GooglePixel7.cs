public class GooglePixel7 : Smartphone, ICamera 
{
    public GooglePixel7(float cost) : base(cost) {}

    public void MakeVideo()
    {
        Console.WriteLine("Make sharp video");
    }
}