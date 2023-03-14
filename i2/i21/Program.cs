using System.Text.Json;

var fr1 = new Fraction(6, 10);
Console.WriteLine(fr1.Simplify());
var fr2 = new Fraction(4, 5);
Console.WriteLine(fr1+fr2);
Console.WriteLine(fr1-fr2);
Console.WriteLine(fr1*fr2);
Console.WriteLine(fr1/fr2);
Console.WriteLine(fr1.Equals(fr2));
Console.WriteLine(fr1.IsProper());
//fr1.Serialize();
Console.WriteLine(Fraction.Deserialize());
class Fraction
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Знаменник не може бути рівним нулю.");
        this.Numerator = numerator;
        this.Denominator = denominator;
    }
    public Fraction Simplify()
    {
        var dfa = DenForAll(Numerator, Denominator);
        Numerator /= dfa;
        Denominator /= dfa;
        return this;
    }
    private int DenForAll(int a, int b)
    {
        while (b != 0)
            (a, b) = (b, a % b);

        return Math.Abs(a);
    }
    public static Fraction operator+(Fraction first, Fraction second)
    {
        return new Fraction(
            first.Numerator * second.Denominator + second.Numerator * first.Denominator, 
            first.Denominator * second.Denominator).Simplify();
    }
    public static Fraction operator-(Fraction first, Fraction second)
    {
        return new Fraction(
            first.Numerator * second.Denominator - second.Numerator * first.Denominator, 
            first.Denominator * second.Denominator).Simplify();
    }
    public static Fraction operator*(Fraction first, Fraction second)
    {
        return new Fraction(
            first.Numerator * second.Numerator, 
            first.Denominator * second.Denominator).Simplify();
    }
    public static Fraction operator/(Fraction first, Fraction second)
    {
        return new Fraction(
            first.Numerator * second.Denominator, 
            first.Denominator * second.Numerator).Simplify();
    }

    public bool Equals(Fraction other)
    {
        this.Simplify();
        other.Simplify();

        return this.Numerator == other.Numerator && this.Denominator == other.Denominator;
    }
    public bool IsProper()
    {
        return Math.Abs(Numerator) < Denominator;
    }
    public override string ToString()
    {
        Simplify();
        return Denominator == 1 ? Numerator.ToString() : $"{Numerator}/{Denominator}";
    }
    public void Serialize()
    {
        using var sw = File.CreateText(@"C:\Users\User\Desktop\Prog\1\i\i21\data.txt");
        sw.Write(JsonSerializer.Serialize(this));
    }

    public static Fraction? Deserialize()
    {
        using var sr = new StreamReader(@"C:\Users\User\Desktop\Prog\1\i\i21\data.txt");
        return JsonSerializer.Deserialize<Fraction>(sr.ReadToEnd());
    }
}