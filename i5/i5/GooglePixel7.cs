public class GooglePixel7 : Smartphone, ICamera
{
    public GooglePixel7(float cost) : base(cost)
    {
    }

    public void MakeVideo()
    {
        Console.WriteLine("Make sharp video");
    }

    public override void MakeCall()
    {
        Console.WriteLine("Make call in Telegram");
    }
}