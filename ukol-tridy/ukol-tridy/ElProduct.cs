class ElProduct : Product
{
    public ElProduct(string Name, double Price, string Manafacturer) : base(Name, Price)
    {
        this.Manafacturer = Manafacturer;
    }

    public string Manafacturer;

    public override void ZobrazInfo()
    {
        Console.WriteLine($"Nazev: {Name}, cena: {Price}.");
        Console.WriteLine($"Vyrobce: {Manafacturer}");
    }
}