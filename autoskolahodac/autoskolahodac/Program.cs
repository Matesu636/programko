

while (true)
{
    int pocetOtazek = 0;
    double uspesnost = 0;


    Console.WriteLine("Vybírej z možností A,B nebo A,B,C");
    Console.WriteLine();


    do
    {
        Console.WriteLine("Zadej počet otázek, které si přeješ zodpovědět:");
        pocetOtazek = int.Parse(Console.ReadLine());
        if (pocetOtazek < 1)
        {
            Console.WriteLine("Počet otázek musí být větší než 0");
        }
    } while (pocetOtazek < 1);


    for (int i = 0; i < pocetOtazek; i++)
    {

        string otazka = File.ReadAllLines("questions.data")[new Random().Next(0, 624)];
        string[] parts = otazka.Split('|');



        Console.WriteLine("Otázka č. {0}: {1}", i + 1, parts[0]);
        int casti = -1;
        for (int j = 0; j < parts.Length; j++)
        {
            casti++;
        }
        if (casti == 3)
        {

            Console.WriteLine($"   A: {parts[2]}");
            Console.WriteLine($"   B: {parts[3]}");
        }
        else
        {

            Console.WriteLine($"  A: {parts[2]}");
            Console.WriteLine($"  B: {parts[3]}");
            Console.WriteLine($"  C: {parts[4]}");
        }


        string odpoved = Console.ReadLine();

        string spravnaOdpoved = otazka.Split("|")[1];
        if (odpoved == spravnaOdpoved)
        {
            uspesnost++;
        }


        Console.WriteLine("Tvoje odpověď: {0}, správná odpověď: {1}", odpoved, spravnaOdpoved);
        Console.WriteLine();
    }


    Console.WriteLine("Konec testu");
    Console.WriteLine("Počet správných odpovědí: {0}", uspesnost);
    Console.WriteLine("Úspěšnost: {0}%", (100 * uspesnost / pocetOtazek));


    Console.WriteLine("Chceš spustit test znovu? (N/A)");
    string volba = Console.ReadLine().ToLower();
    if (volba == "a")
    {
        pocetOtazek = 0;
        uspesnost = 0;
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Díky za použití testu!");
        break;
    }

}