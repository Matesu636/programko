bool success = false;
int Intcislo1 = 0;
int Intcislo2 = 0;

do
{
    Console.WriteLine("Enter a number:");
    string cislo1 = Console.ReadLine();

    Intcislo1 = 0;
    success = int.TryParse(cislo1, out Intcislo1);
    
          


    Console.WriteLine("Enter a number:");
    string cislo2 = Console.ReadLine();

    Intcislo2 = 0;
    success = int.TryParse(cislo2, out Intcislo2);

} while (!success);

Console.WriteLine("zvol Operaci: +,-");
string operace = Console.ReadLine();

if (operace ==  "+")
{
    Console.WriteLine(Intcislo1 + Intcislo2);
}

else if (operace == "-")
{
    Console.WriteLine(Intcislo1 - Intcislo2);
}
else
{
    Console.WriteLine("si debilni");
}