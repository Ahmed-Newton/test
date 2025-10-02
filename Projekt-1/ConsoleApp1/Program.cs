/*
// Börjar med att skriva ut "Skriv din mening här:" på konsolen
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Skriv din mening här: ");
// Tar emot vokaler från anändaren
string vokaler = Console.ReadLine();
// Räknar antalet meningar i den givna strängen
int antalmeningar = 0;
antalVokaler = vokaler;
for (int i = 0; i < vokaler.Length; i++)
{
    if (vokaler[i] == '.' || vokaler[i] == '!' || vokaler[i] == '?')
    {
        antalmeningar++;
    }
    if (vokaler[i] == 'a' || vokaler[i] == 'e' || vokaler[i] == '?' || vokaler[i] == 'o' || vokaler[i] == 'u' || vokaler[i] == 'y' ||
        vokaler[i] == 'A' || vokaler[i] == 'E' || vokaler[i] == 'I' || vokaler[i] == 'O' || vokaler[i] == 'U' || vokaler[i] == 'Y')
    {
        antalVokaler++;
    }
}

Console.WriteLine($"Din mening: {vokaler} \n {antalmeningar} \n {antalVokaler}");


int[] arrays = { 1, 2, 3, 4, 5 };
//char[] arrach = { 'a', 'b', 'c', 'd', 'e', 'f' };
for (int i = 0; i < arrays.Length; i++)
{
    Console.WriteLine(array[i]);
}

// Övning 1
using System.Security.Cryptography.X509Certificates;

int[] arrays = { 1, 2, 3, 4, 5 };
//int sum = arrays.Sum();
int sum = 0;
for (int i = 0; i < arrays.Length; i++)
{
    sum += arrays[i];
}
 Console.WriteLine(sum);
// Övning 2
int[] arrays2 = { 11, 22, 33, 44, 55 };
//int sumMax = arrays2.Max();
int sumMax = 0;
for (int i = 0; i < arrays2.Length; i++) 
{
    sumMax = arrays2[i];
}
Console.WriteLine($"Ö2=  "+sumMax);

// Övning 3
string[] stängar = { "Ahmed", "Zaynel", "Erdogan", "Man", "Turkiet" };
string Längst = stängar[0];
for (int i = 0; i < stängar.Length; i++)
{
    if (stängar[i].Length > Längst.Length)
    {
        Längst = stängar[i];
    }
}
Console.WriteLine(Längst);
// Övning 4
string[] string1 = { "Ahmed", "Zaynel", "Erdogan", "Man", "Turkiet" };
string Kortast = string1[0];
for (int i = 0; i < string1.Length; i++) {
    if (string1[i].Length < Kortast.Length)
    {
        Kortast = string1[i];
    }
}
Console.WriteLine(Kortast);

// Övning 3 lektion hitta skillnaden mellan längsta och kortaste tal
int[] arrays3 = { 11, 22, 33, 44, 55 };
//int sumMax = arrays2.Max();
int sumMaxx = arrays3[0];
int  SumMin = arrays3[0];
int resultat = 0;
for (int i = 0; i < arrays2.Length; i++)
{
    if (arrays3[i] > sumMaxx)
    {
        sumMaxx = arrays3[i];
    }
    if (arrays3[i] < SumMin)
    {
        SumMin = arrays3[i];
    }
}
resultat = sumMaxx - SumMin;
Console.WriteLine($"Ö3=  " + resultat);

 
int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] input = {};
int x = 0;
Console.WriteLine("Mata in här: ");
string UserInput = Console.ReadLine().ToString();
for (int i = 0; i < UserInput.Length; i++);
{
    int test = UserInput[x];
    Console.WriteLine(test);
}


using System.Runtime.InteropServices.Marshalling;

int[] num = new int[10]; // Step 1: create array for 10 numbers

Console.WriteLine("Skriv 10N tal:");
for (int i = 0; i < num.Length; i++)
{
    Console.Write($"Number {i + 1}: ");
    num[i] = int.Parse(Console.ReadLine());
}
int num1 = num[];
Console.WriteLine($"Ge X tal:  " { num1 });

using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

void hej()
{
    Console.WriteLine("Hej");
}
hej();

void SägTill(string x)
{
    Console.WriteLine($"Hej ... " + x );
}
SägTill("Ahmed");

void kvadrera(int x, int y)
{
    int resultat = 1;
    for (int i = 0; i < y; i++)
    {
        resultat *= x;
    }
    Console.WriteLine(resultat);
}
kvadrera(2,4);

void ÄrJämnt(int x) {
    if (x % 2 == 0)
    {
        Console.WriteLine("Jämnt");
    }
    else
    {
        Console.WriteLine("Ojämt");
    }
}
ÄrJämnt(5);


int Medelvärdet(int[] arrays)
{
    int sum = 0;
    for (int i = 0; i < arrays.Length; i++)
    {
        sum += arrays[i];
    }
    return sum / arrays.Length;
    //int medel = sum / arrays.length;

}
Console.WriteLine(Medelvärdet(new int[] { 1, 2, 3, 4, 5 }));

void HittaNamn(string param) {
    string[] namn = { "Ahmed", "Daniel", "babyface" };
    for (int i = 0; i < namn.Length; i++) {
        if (namn[i] == param)
        {
            Console.WriteLine("Finns " + param);
            return;
        }
        else
        {
            Console.WriteLine("Finns inte " + param);
            return;
        }
    }
}
HittaNamn("Ahmed");
HittaNamn("Adam");

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

while (true)
{
    string x = "1: Skriv ut alla tal i en array \n 2: Beräkna summan av två tal: \n 3: Hitta största talet i en array: \n 4: Beräkna summan av hela arrayen:";
    Console.WriteLine(x);
    int selectmenu = int.Parse(Console.ReadLine());
    int[] array = { 1, 2, 3, 4, 5 };
    switch (selectmenu)
    {
        case 1:
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            break;
        case 2:
            Console.WriteLine("skriv 2 tal: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum);
            break;
        case 3:
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            break;
        case 4:
            int sumArray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumArray += array[i];
            }
            Console.WriteLine(sumArray);
            break;
    }
}

//using System.Text.RegularExpressions;

Console.Clear();
while(true)
{
    Console.WriteLine("--------------------------------");
    string x = "Välj \n 1: Addera  \n 2: subtraktion \n 3: multiplikation \n 4: division: \n 5: Avsluta programmen \n 6: Rensa";
    Console.WriteLine(x);
    int Kalkylmenu = int.Parse(Console.ReadLine());
    switch (Kalkylmenu)
    {
        case 1:
            Console.WriteLine("skriv 2 tal: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            // 3OrdChecker(a, b);
            double sum = Addera(a, b);
            Console.WriteLine(sum);
            break;
        case 2:
            Console.WriteLine("skriv 2 tal: ");
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            double sum1 = subtraktion(c, d);
            Console.WriteLine(sum1);
            break;
        case 3:
            Console.WriteLine("skriv 2 tal: ");
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            double sum2 = multiplikation(e, f);
            Console.WriteLine(sum2);
            break;
        case 4:
            Console.WriteLine("skriv 2 tal: ");
            int g = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double sum3 = division(g, h);
            break;
        case 5:
            Console.WriteLine("Stänger av kalkylator");
            return;
        case 6:
            Console.Clear();
            break;
    }
}


double Addera(int a, int b)
{
    return a + b;
}
double subtraktion(int a, int b)
{
    return a - b;
}
double multiplikation(int a, int b)
{
    return a * b;
}
double division(double a, double b)
{
    if (b != 0) {
        double sum = Math.Round(a / b, 2);
        Console.WriteLine(sum);
        return sum;
    } else {
        Console.WriteLine("venne");
        return 0;
    }
}


void OrdChecker(int a, int b){
    double x = a + b;
    double y = !int.TryParse(x, out _);
    if (y = true) ; {
        Console.WriteLine("true");
    } else
    {
        Console.WriteLine("False")
    }
    return y
}

Console.Clear();
MetodExempel1();
MetodExempel2();
void MetodExempel1()
{
    string[] array = { "Ahmed", "Daniel", "CoPilot", "ChatGPT", "AI" };
    string längsta = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > längsta.Length)
        {
            längsta = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Längsta ordet är {längsta} och index är {index}");
    return;
}

void MetodExempel2()
{
    //Hitta största talet i en array
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int längsta = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > längsta)
        {
            längsta = array[i];
            index = i;
        }
    }
    Console.WriteLine($"Längsta är {längsta}");
    return;
}

int x = 0;
int sum = 0;
while (x <= 10)
{
    sum += x;
    x++;
}

Console.WriteLine(sum);

//övning 1
Console.Clear();
int i = 10;
while (i >= 0)
{
    Console.WriteLine(i);
    i--;
}

//övning 2 Addera och 0 ger resultat
Console.Clear();
Console.WriteLine("Skriv några tal: ");

int i = 1;
int xtal = 0;
int summan = 0;

while (true)
{
    Console.Write($"Skriv tal #{i}: ");

    xtal = int.Parse(Console.ReadLine());

    if (xtal == 0)
    {
        Console.WriteLine($"Slut. Summan är: {summan}");
        break;
    }
    summan += xtal;
    Console.WriteLine($"[ {i} ] Delsumma: {summan}");
    i++;
}

*/

    int[] xtal = { 1, 10, 3 };
    int min = xtal[0];
    int max = xtal[0];
    for (int i = 1; i < xtal.Length; i++)
    {
        if (xtal[i] < min) min = xtal[i];
        if (xtal[i] > max) max = xtal[i];
    }

    int total = min + max;
    Console.WriteLine($"Min: {min}, Max: {max}, Totalt {total}");