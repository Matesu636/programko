using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

while (true) 
{
    
    string random()
    {
        string[] otazky = File.ReadAllLines("questions.data");
        Random rnd = new Random();
        int otazka = rnd.Next(0, 624);

        return otazky[otazka];
    }
    string[] rozdeleni()
    {
        string x = random();
        string[] parts = x.Split('|');
        int casti = -1;
        for (int i = 0; i < parts.Length; i++)
        {
            casti++;
        }
        if (casti == 3)
        {
            Console.WriteLine($"{parts[0]}");
            Console.WriteLine($"  Moznost 1: {parts[2]}");
            Console.WriteLine($"  Moznost 2: {parts[3]}");
        }
        else
        {
            Console.WriteLine($"{parts[0]}");
            Console.WriteLine($"  Moznost 1: {parts[2]}");
            Console.WriteLine($"  Moznost 2: {parts[3]}");
            Console.WriteLine($"  Moznost 3: {parts[4]}");
        }
        return parts;
    }
    //string[] odpoved()
    //{

    //}
 

    rozdeleni();
    return;
}









for ( int i = 0;i > 0;i++)
{

}

