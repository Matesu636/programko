class Kniha : Product
{
    public Kniha(string Name, double Price, string author) : base(Name, Price)
    {

    }

    public string Author;

    public override void ZobrazInfo()
    {
        Console.WriteLine($"Nazev: {Name}");
        Console.WriteLine($"Autor: {Author}");
        Console.WriteLine($"cena: {Price}");
    }
}