double koeficient(string koef)
{
    while (true)
    {
        Console.WriteLine("Napis koeficient "+ koef);
        string  cislo= Console.ReadLine(); 
        double.TryParse(cislo, out double cislo1);
        if (double.TryParse(cislo, out  cislo1))
        {
            return cislo1;
        }
        else
        {
            Console.WriteLine("Neni to cislo");
        }
    }
}

double a = koeficient("a");
double b = koeficient("b");
double c = koeficient("c");


Console.WriteLine("Rovnice je " + a + "*x*x + " + b + "*x *+"  + c);

double diskriminant = b * b - 4 * a * c;
if (diskriminant < 0)
    {
    Console.WriteLine("Neni reseni");
    }
