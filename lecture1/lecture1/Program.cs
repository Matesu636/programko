// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int x;
x = 2;

int y = 3;

double procento = 0.42;

//Vypisuje čísla

/*kouole
 * more
*/

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(procento);

string name = "Slavkon";
Console.WriteLine(name);
Console.WriteLine("Ahoj, " + name);
Console.WriteLine("Ahoj, {0}" + name);   //složené závorky- altgr + B, AltGr + N



int number1 = 42;
int number2 = 24;



Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
Console.WriteLine(number1 + number2);
Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);

string jmeno = "David";
Console.WriteLine($"Ahoj,  {jmeno}");

Console.WriteLine($"{number1} / {number2} = {number1 / number2}");



double number3 = 42;
double number4  = 24;

Console.WriteLine($"{number3} / {number4} = {number3 / number4}");


//pretzpovani promenne
double result2 = number3 / number4;
Console.WriteLine(result2);
int result2int = (int)result2;
Console.WriteLine(result2int);




bool bool1 = true;
bool bool2 = false ;



Console.WriteLine("{0} && {1} = {2}", bool1, bool2, bool1 && bool2);
Console.WriteLine("{0} || {1} = {2}", bool1, bool2, bool1 || bool2);


int cislo = 7;
Console.WriteLine("{0} == 7 ->{1}", cislo, cislo = 7);

Console.WriteLine("Kdo si");
string nazev = Console.ReadLine();
Console.WriteLine("hello, " + nazev);




Console.WriteLine("napis cislo"); 
string cisloOdUzivatele =  Console.ReadLine();
int cisloProcessed;
bool success = int.TryParse(cisloOdUzivatele, out cisloProcessed);

Console.WriteLine($"Success = {success}");
Console.WriteLine(cisloProcessed +3);

