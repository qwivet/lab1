using System.Text;

Console.OutputEncoding = Encoding.Unicode;
var anatolii = new Predator("Анатолій", new Claws(10), new Teeth(25));
anatolii.Hunt();
anatolii.Roar();
anatolii.Run();
anatolii.Sleep();
Console.WriteLine(anatolii.Equals(new Predator("Онуфрій", new Claws(10), new Teeth(25))));
Console.WriteLine(anatolii.ToString());
Console.WriteLine(anatolii.GetHashCode());

public class Predator
{
    public string Name { get; set; }
    public Claws Claws { get; set; }
    public Teeth Teeth { get; set; }

    public Predator(string name, Claws claws, Teeth teeth)
    {
        Name = name;
        Claws = claws;
        Teeth = teeth;
    }

    public void Roar()
    {
        Console.WriteLine($"{Name} гарчить на всі {Teeth.Count} зуба");
    }

    public void Run()
    {
        Console.WriteLine($"{Name} бігає.");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} спить.");
    }

    public void Hunt()
    {
        Console.WriteLine($"{Name} атакує здобич своїми шикарними {Claws.Length}-ти сантиметровими кігтями");
    }

    public override bool Equals(object? obj)
    {
        return obj is Predator pr && Name == pr.Name && Claws.Length == pr.Claws.Length && Teeth.Count == pr.Teeth.Count;
    }

    public override string ToString()
    {
        return $"{Name}, {Teeth.Count} зуба, {Claws.Length}-ти сантиметрові кігті";
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

public class Claws
{
    public int Length { get; set; }

    public Claws(int length)
    {
        Length = length;
    }
    public override bool Equals(object? obj)
    {
        return obj is Claws cl && Length == cl.Length;
    }

    public override string ToString()
    {
        return $"{Length}-ти сантиметрові кігті";
    }

    public override int GetHashCode()
    {
        return Length.GetHashCode();
    }
}

public class Teeth
{
    public int Count { get; set; }

    public Teeth(int count)
    {
        Count = count;
    }
    public override bool Equals(object? obj)
    {
        return obj is Teeth teeth && Count == teeth.Count;
    }

    public override string ToString()
    {
        return $"{Count} зуба";
    }

    public override int GetHashCode()
    {
        return Count.GetHashCode();
    }
}