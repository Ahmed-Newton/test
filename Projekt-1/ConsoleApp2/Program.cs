
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2;
using System;
using System.Security.Cryptography.X509Certificates;

/*class Book
{
    public string title;
    public string author;

    public int id;

    public Book(string title, string author, int iban)
    {
        this.title = title;
        this.author = author;
        this.id = id;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nID: {id}");
        
    }
}

class Program
{
    static void Main()
    {
        Random id = new Random();
        int ibanRandom = id.Next(10000, 99999);
        Book myBook = new Book("2015", "George Lucas", ibanRandom);
        myBook.Print();
    }
}

class Elev
{
    public string Namn;
    public string Efternamn;
    public string Klass;
    public int Age;

    public Elev(string namn, string efternamn, string klass, int age)
    {
        Namn = namn;
        Efternamn = efternamn;
        Klass = klass;
        Age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Förnamn: {Namn}\nEfterNamn: {Efternamn}\nKlass: {Klass}\nÅlder: {Age}");
    }
}

class Program
{
    static void Main()
    {
        var elev = new Elev("George", "Lucas", "Klass 9", 16);
        elev.Print();
    }
}

using System;
using System.Diagnostics.Contracts;
using System.Runtime.ExceptionServices;

class Metod
{
    // Returnerar (ord, index) för längsta strängen i arrayen.
    public static (string ord, int index) Ta(string[] x)
    {
        int bastIndex = 0;
        string bastOrd = x[0] ?? "";
        int maxLangd = bastOrd.Length;

        for (int i = 1; i < x.Length; i++)
        {
            string w = x[i] ?? "";
            int len = w.Length;

            if (len > maxLangd)
            {
                maxLangd = len;
                bastOrd = w;
                bastIndex = i;
            }
        }

        return (bastOrd, bastIndex);
    }
    //Övning 2: Skriv en metod som tar emot en array av doubles och returnerar det största talet
    public static int TaAr(int[] a)
    {
        int störst = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > störst)
                störst = a[i];
        }
        return störst;
    }
}

// Exempelanvändning:
class Program
{
    static void Main()
    {
        var arr = new[] { "hej", "hallå", "tjena", "OOOOOOooooBror" };
        var resultat = Metod.Ta(arr);
        Console.WriteLine($"Längsta är \"{resultat.ord}\" på index {resultat.index}");
        int[] arrx = new int[] { 1, 22, 33 };
        var resultatx = Metod.TaAr(arrx);
        Console.WriteLine($"Längsta tal är {resultatx}");
    }
}



using System;
public class Produkt
{
    public string Namn;
    public double Pris;
    public int Antal;

    public Produkt(string namn, double pris, int antal)
    {
        Namn = namn;
        Pris = pris;
        Antal = antal;
    }
}

public class Kundvagn
{
    private Produkt[] produkter = new Produkt[10];
    private int antalRader = 0;
    public void LaggTillProdukt(Produkt p)
    {
        produkter[antalRader] = p;
        antalRader++;
    }
    public double HamtaTotalPris()
    {
        double summa = 0;
        for (int i = 0; i < antalRader; i++)
        {
            summa += produkter[i].Pris * produkter[i].Antal;
        }
        return summa;
    }
    public int HamtaTotaltAntal()
    {
        int totalt = 0;
        for (int i = 0; i < antalRader; i++)
        {
            totalt += produkter[i].Antal;
        }
        return totalt;
    }
}
public class Program
{
    public static void Main()
    {
        Console.Clear();
        Kundvagn k = new Kundvagn();
        k.LaggTillProdukt(new Produkt("iPhone", 10000, 61));
        k.LaggTillProdukt(new Produkt("Samsung", 9999, 1));
        k.LaggTillProdukt(new Produkt("Chromebook", 3000, 1));
        Console.WriteLine("Totalt antal: " + k.HamtaTotaltAntal());
        Console.WriteLine("Totalt pris: " + k.HamtaTotalPris());
    }
}
*/
//-------------------------------------------
/*  Skriv en metod som tar in en sträng
exempel "S1ka2 n13i m3d?" Och räknar ut
antalet siffror och skriver ut dem: exempel
antalSiffror i sträng: 5

//-------------------------------------------
using System;
using System.Diagnostics;

class ÖvningSträngTillAntalSiffror
{
    static void Main()
    {
        string text = "S1ka2 n13i m3d?";
        int antalSiffror = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (c >= '0' && c <= '9') // är tecknet en siffra?
            {
                antalSiffror++;
            }
        }
        Console.WriteLine("antalSiffror i sträng: " + antalSiffror);
    }
}

Skriv en metod som tar in en Array och
adderar det minsta värdet med det största
värdet i array
Exempel: [1,10,3] output: 1+3 = 4

class Program
{
    static void Main()
    {
        int[] xtal = { 1, 10, 3 };
        int min = xtal[0];
        int max = xtal[0];

        for (int i = 1; i < xtal.Length; i++)
        {
            if (xtal[i] < min) min = xtal[i];
            if (xtal[i] > max) max = xtal[i];
        }

        int total = min + max;
        Console.WriteLine($"Min: {min}, Max: {max}, Totalt: {total}");
    }
}
*/
/*
1. Enkel klass & objekt: Skapa en klass Person med privata fält för förnamn och
efternamn (string). Skriv publika egenskaper FirstName och LastName för att
kapsla in fälten. Lägg också till en konstruktor som tar för- och efternamn som
parametrar och sätter fälten. Skriv en Main-metod som skapar ett Person-objekt,
tilldelar namn via konstruktorn, och skriver ut personens fulla namn (t.ex. genom att
läsa egenskaperna och Console.WriteLine dem sammanfogade).
Syfte: Träna på grundläggande klassstruktur, fält vs property, och
objektinstansiering.
*/

public class Human
{
    // Klass Person
    class Person
    {
        // Privata fält
        private string firstName;
        private string lastName;

        // Publika egenskaper som kapslar in fälten
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Konstruktor som tar för- och efternamn som parametrar
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett Person-objekt med hjälp av konstruktorn
            Person person = new Person("Anna", "Svensson");

            // Skriver ut hela namnet via egenskaperna
            Console.WriteLine("Fullständigt namn: " + person.FirstName + " " + person.LastName);
        }
    }
}
