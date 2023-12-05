
while (true)
{
string[] tvary = new string[] { "square", "rectangle", "sphere", "triangle", "cube", "block", "globe", "cone"};
void vyber()
{
    Console.WriteLine("tvary s indexem");
    Console.WriteLine();
    for (int i = 0; i < tvary.Length; i++)
    {

        Console.WriteLine(i+1 + ") " + tvary[i]);
        
    }
}
vyber();
Console.WriteLine();   
Console.WriteLine("Vyber si tvar");

int cislo;
    if (int.TryParse(Console.ReadLine(), out cislo) ) 
    {
        if (cislo > 0 || cislo <9)
        {
            switch (cislo)
            {
                case 1:
                    PrintSquare();
                    break;
                case 2:
                    PrintRectangle();
                    break;
                case 3:
                    PrintSphere();
                    break;
                case 4:
                    PrintTriangle();
                    break;
                case 5:
                    PrintCube();
                    break;
                case 6:
                    PrintBlock();
                    break;
                case 7:
                    PrintGlobe();
                    break;
                case 8:
                    PrintCone();
                    break;

            }

        }

        else
        {
            Console.WriteLine("Neplatný vstup. Zadejte prosím platné číslo.");
        
        }

        Console.WriteLine("Napis konec pro konec programu, Enter pro pokracovani");
        string konec= Console.ReadLine();
        if(konec == "konec")
        {
            break;
        }
        static void PrintSquare()
        {
            while (true)
            {
                Console.WriteLine("Zadej starnu a");
                string strana = Console.ReadLine();
                double.TryParse(strana, out double a);

                if (a == 0)
                {
                    Console.WriteLine("musis dat nulu");
                }
                else
                {
                    Console.WriteLine("Obvod = " + a * 4);
                    Console.WriteLine("Obsah = " + a * a);
                    break;
                }
            }
        }
        static void PrintRectangle()
        {
            while (true)
            {
                Console.WriteLine("Zadej stranu a");
                string strana = Console.ReadLine();
                double.TryParse(strana, out double a);

                Console.WriteLine("Zadej stranu b");
                string stranab = Console.ReadLine();
                double.TryParse(stranab, out double b);

                if (a == 0 || b == 0)
                {
                    Console.WriteLine("musis dat nulu");
                }
                else
                {
                    Console.WriteLine("Obvod = " + (a * 2 + b * 2));
                    Console.WriteLine("Obsah = " + a * b);
                    break;
                }
            }
        }
        static void PrintSphere()
        {
            while (true)
            {
                Console.WriteLine("Zadej polomer");
                string prumer = Console.ReadLine();
                double.TryParse(prumer, out double r);

                if (r == 0)
                {
                    Console.WriteLine("musis dat nulu");
                }
                else
                {
                    Console.WriteLine("Obvod = " + 2 * Math.PI * r);
                    Console.WriteLine("Obsah = " + Math.PI * r * r);
                    break;
                }
            }
        }
        static void PrintTriangle()
        {
            while (true)
            {
                Console.WriteLine("Zadej stranu a");
                string strana = Console.ReadLine();
                double.TryParse(strana, out double a);

                Console.WriteLine("Zadej b");
                string stranab = Console.ReadLine();
                double.TryParse(stranab, out double b);

                Console.WriteLine("Zadej c");
                string stranac = Console.ReadLine();
                double.TryParse(stranac, out double c);

                if  (a > 0 || b > 0 || c > 0)
                {
                    Console.WriteLine("musis dat vetsi cislo");
                }
                else
                {
                static bool PlatnyTrojuhelnik(double a, double  b, double c)
                {
                    return (a + b > c) && (b + c > a) && (c + a > b);
                }
                    if(PlatnyTrojuhelnik(a,b,c))
                    {
                        double s = (a+b+c)/2;
                        double her= s*(s-a)*(s-b)*(s-c);
                        double obsah = Math.Sqrt(her);
                        double obvod = a + b + c;

                        Console.WriteLine("Obvod = "+ obvod);
                        Console.WriteLine("Obsah = " + obsah);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Neni to platny trojuhelnik");
                    }
                }
            }
        }
        static void PrintCube()
        {
            while (true)
            {
                Console.WriteLine("Zadej stranu a");
                string strana = Console.ReadLine();
                double.TryParse(strana, out double a);

                if (a == 0)
                {
                    Console.WriteLine("musis dat nulu");
                }
                else
                {
                    Console.WriteLine("Povrch = " + a * a * 6);
                    Console.WriteLine("Objem = " + a * a * a);
                    break;
                }
            }
        }
        static void PrintBlock()
        {
            while (true)
            {
                Console.WriteLine("Zadej stranu a");
                string strana = Console.ReadLine();
                double.TryParse(strana, out double a);

                Console.WriteLine("Zadej stranu b");
                string stranab = Console.ReadLine();
                double.TryParse(stranab, out double b);

                Console.WriteLine("Zadej stranu c");
                string stranac = Console.ReadLine();
                double.TryParse(stranac, out double c);

                if (a == 0 || b == 0 || c == 0)
                {
                    Console.WriteLine("musis dat nulu");
                }
                else
                {
                    Console.WriteLine("Povrch = " + (2 * (a * b + b * c + a * c)));
                    Console.WriteLine("Objem = " + a * b * c);
                    break;
                }
            }
        }
        static void PrintGlobe()
        {
            while (true)
            {
                Console.WriteLine("Zadej polomer");
                string prumer = Console.ReadLine();
                double.TryParse(prumer, out double r);

                if (r == 0)
                {
                    Console.WriteLine("musis dat nulu");
                }
                else
                {
                    Console.WriteLine("Povrch = " + 4 * Math.PI * r * r);
                    Console.WriteLine("Objem = " + ((4* Math.PI * r*r*r)/3));
                    break;
                }
            }
        }
        static void PrintCone()
        {
            while (true)
            {
                Console.WriteLine("Zadej polomer");
                string polomer = Console.ReadLine();
                double.TryParse(polomer, out double r);

                Console.WriteLine("Zadej vysku");
                string vyska = Console.ReadLine();
                double.TryParse(vyska, out double v);

                double p = r * r + v * v;
                double delka = Math.Sqrt(p);
                double povrch = (Math.PI * r * r) + (Math.PI * r * delka);
                double objem = Math.PI * r * r * v / 3;
                if (r == 0 || v == 0)
                {
                    Console.WriteLine("musis dat nulu");
                }
                else
                {
                    Console.WriteLine("Povrch = " +  povrch);
                    Console.WriteLine("Objem = " + objem);
                    break;
                }
            }
        }
        Console.WriteLine();

     }
}