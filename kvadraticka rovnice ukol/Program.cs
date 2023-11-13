double koeficient(string koef)
{
    while (true)
    {
        Console.WriteLine("Napis koeficient "+ koef);
        string  cislo= Console.ReadLine(); 
        double.TryParse(cislo, out double x);
        if (true)
        {
            Console.WriteLine("Neni to cislo");
        }
        else
        {
            break;
        }
    }
}

double a = koeficient("a");
double b = koeficient("b");
double c = koeficient("c");