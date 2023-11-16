while (true)
{
    double koeficient(string koef)
    {
        while (true)
        {
            Console.WriteLine("Napis koeficient " + koef);
            string cislo = Console.ReadLine();
            double.TryParse(cislo, out double cislo1);
            if (double.TryParse(cislo, out cislo1))
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


    Console.WriteLine("Rovnice je " + a + "*x*x + " + b + "*x + " + c);
    double mocninab = Math.Pow(b, 2);
    double diskriminant = (mocninab - (4*a*c));
    if (diskriminant < 0)
    {
        Console.WriteLine("Neni reseni");
    }
    if(diskriminant == 0)
    {
        while (true)
        {
            double koren1 = ((-b) + Math.Sqrt(diskriminant)) / (2 * a);
            Console.WriteLine("x1= " + koren1);
            Console.WriteLine("Zadej parameter x");
            string parametr = Console.ReadLine();
            if (parametr == "stop")
            {
                break;
            }
            if (double.TryParse(parametr, out double x))
            {
                double vysledek = a * x * x + b * x + c;
                Console.WriteLine(a + x + "^2 + " + b + "*" + x + " + " + c + " = " + vysledek);
            }
            else
            {
                Console.WriteLine("To neni cislo");
            }

        }
    }
    else
    {
        double koren1 = ((-b) + Math.Sqrt(diskriminant)) / (2 * a);
        double koren2 = ((-b) - Math.Sqrt(diskriminant)) / (2 * a);
        Console.WriteLine("x1= " + koren1);
        Console.WriteLine("x2= " + koren2);
    }


    while (true)
    {
        Console.WriteLine("Zadej parameter x");
        string parametr = Console.ReadLine();
        if (parametr == "stop")
        {
            break;
        }
        if (double.TryParse(parametr, out double x))
        {
            double vysledek = a * x * x + b * x + c;
            Console.WriteLine(a + x + "^2 + " + b + "*" + x + " + " + c + " = " + vysledek);
        }
        else
        {
            Console.WriteLine("To neni cislo");
        }

    }
    Console.WriteLine("Jestli chces pokracovat zmackni enter a pro konec napis konec");
    string konec= Console.ReadLine();
    if (konec == "konec")
    {
        break;
    }
}

