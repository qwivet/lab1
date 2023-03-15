public class iPhone : Smartphone, ICamera
{
    public iPhone(float cost) : base(cost) {}
    public void MakeVideo()
    {
        Console.WriteLine("Make beautiful photo");
    }
    public override void MakeCall()
    {
        Console.WriteLine("Make call in Messager");
    }
}