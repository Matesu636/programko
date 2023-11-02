//int PlusJedna(int x)
//{
//    return x + 1;
//}
//int x = 3;

//int y = PlusJedna(x);

//Console.WriteLine(y);

//float maximum(float x,float y)
//{
//    if (x > y)
//    {
//        return x;
//    }

//    else
//    {
//        return y;  
//    }
//}

//float x = 0;   
//float y = 9;
//Console.WriteLine(maximum(x,y));

//bool aresame(float x, float y)
//{
//    if (x == y)
//    {
//        return true;
//    }

//    else
//    {
//        return false;
//    }
//}

//float x = 7;
//float y = 7;
//Console.WriteLine(aresame(x, y));

Console.WriteLine("Napis cislo");
int CisloOdUyivatele()
{
    string input = Console.ReadLine();
    int Intcislo;
    int.TryParse(input, out Intcislo);
    return Intcislo;
}


CisloOdUyivatele(); 