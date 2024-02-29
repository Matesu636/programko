class Product
{
    public string Name;
    public double Price;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }


    public virtual void ZobrazInfo()
    {
        Console.WriteLine($"Nazev: {Name}, cena: {Price}.");    
    }
}