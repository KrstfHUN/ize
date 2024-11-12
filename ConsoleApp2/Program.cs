using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //0-tól 10-ig, lépésszám +1
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+1+ " ");
            }
            Console.WriteLine();

            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            //kettesével
            for (int i = 0; i < 10; i+=2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int[] elsoTomb = { 1, 2, 3, };
            int N = 10;
            int[] masodikTomb = new int[N];

            for (int i = 0; i < elsoTomb.Length; i++)
            {
                Console.WriteLine($"{i + 1}. elem: {elsoTomb[i]}");
            }

            Console.WriteLine("______________________________") ;

            for (int i = 0; i < masodikTomb.Length; i++)
            {
                masodikTomb[i] = i + 1;
                Console.WriteLine($"{i+1}. elem: {masodikTomb[i]}");
            }

            Console.WriteLine($"Az első tömb elemeinek száma: {elsoTomb.Length}") ;
            Console.WriteLine($"A második tömb elemeinek száma: {masodikTomb.Length}");
            Console.WriteLine($"A legkisseb érték a második tömbben: {masodikTomb.Min()}");
            Console.WriteLine($"A legnagyobb érték a második tömbben: {masodikTomb.Max()}");
            Console.WriteLine($"Az első érték a második tömbben: {masodikTomb[0]}");
            Console.WriteLine($"Az utolsó érték a második tömbben: {masodikTomb[N-1]}");
            Console.WriteLine();

            string s = "Ez itt egy mondat";
            Console.WriteLine(s);
            Console.WriteLine($"A negyedik karakter: {s[3]}");

            int s_hossz = s.Length;
            for (int i = 0; i < s_hossz; i++)
            {
                Console.Write(s[i] + " ");
            }

            Console.WriteLine("______________________________________-") ;
            Console.WriteLine();
            //kis karakter
            Console.WriteLine(s.ToUpper() );
            //nagy karakter
            Console.WriteLine(s.ToLower() );



            //elágazások
            Console.Write("Kérek egy számot: ") ;
            int szam =Convert.ToInt32( Console.ReadLine() );
            if (szam > 0)
            {
                Console.WriteLine("Ez a szám nagyobb mint 0");
            }

            else if (szam == 0)
            {
                Console.WriteLine("Ez a szám a 0, se pozitív se negatív");
            } else
            {
                Console.WriteLine("Ez a szám kisebb mint 0");
            }

            Console.WriteLine(szam > 3? "A szám nagyobb mint 3" : "A szám kisebb mint 3") ;

            Console.WriteLine("Kérek egy egész számot: ") ;
            int a = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Kérek mégegy számot: ") ;
            int b = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Válasszon az alábbi menüpontok közül");
            Console.WriteLine("\ta.: Összeadás\tb.: Szorzás\n\tc.: Kivonás\td.: Osztás");
            Console.WriteLine("A választott menüpont: ") ;
            char valasz = Convert.ToChar( Console.ReadLine() );
            switch (valasz)
            {
                case 'a':
                    Console.Write($"{a} + {b} = ");
                    int ertek = Convert.ToInt32(Console.ReadLine());
                    if (ertek == a + b)
                    {
                        Console.WriteLine("Helyes válasz");
                    }
                    else
                    {
                        Console.WriteLine($"A válasz helytelen. Helyes válasz: {a + b}");
                    }
                    break;
                case 'b':
                    Console.Write($"{a}*{b} = ");
                    int ertek2 = Convert.ToInt32(Console.ReadLine());
                    if (ertek2 == a * b)
                    {
                        Console.WriteLine("Helyes válasz");
                    }
                    else
                    {
                        Console.WriteLine($"Helytelen válasz. Helyes válasz: {a * b}");
                    }
                    break;
                case 'c':
                    Console.Write($"{a}-{b} = ");
                    int ertek3 = Convert.ToInt32(Console.ReadLine());
                    if (ertek3 == a - b)
                    {
                        Console.WriteLine("Helyes válasz");
                    }
                    else
                    {
                        Console.WriteLine($"Helytelen válasz. Helyes válasz: {a - b}");
                    }
                    break;
                case 'd':
                    Console.Write($"{a}/{b} = ");
                    int ertek4 = Convert.ToInt32(Console.ReadLine());
                    if (ertek4 == a / b)
                    {
                        Console.WriteLine("Helyes válasz");
                    }
                    else
                    {
                        Console.WriteLine($"Helytelen válasz. Helyes válasz: {a / b}");
                    }
                    break;
                default: Console.WriteLine("Nincs ilyen menüpont");
                    break;
            }

            if (a % 2 == 0)
            {
                Console.WriteLine($"A/Az {a} páros szám");
            }
            else
            {
                Console.WriteLine($"A/Az {a} páratlan");
            }

            if ((a % 2) == 0 || b % 2 == 0) 
            { 
                Console.WriteLine("Legalább egy páros");
            }
            */




            Feladat2();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            Console.ReadLine();
        }

        static void Feladat2()
        {
            for (int i = 0; i< 20; i++)
            {
                if (i % 2 == 0)
                { 
                    Console.Write(i +" ");
                }                
            }
        }

        static void Feladat3()
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }
        }

        static void Feladat4() 
        {
            Console.WriteLine();
            Console.Write("kerek egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("kerek megeggyet: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a} nagyobb");
            }
            else if (b > a)
            {
                Console.WriteLine($"{b} nagyobb");
            }
            else 
            { 
                Console.WriteLine("a két szám egyenlő");
            }
        }

        static void Feladat5() 
        {
            Console.WriteLine();
            Console.Write("kerek egy szamot: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine((i+1) * a + " ");
            }
        }

        static void Feladat6() 
        {
            Console.WriteLine();
            int[] tomb = new int[5];
            Random rand = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rand.Next(0, 6);
                Console.WriteLine($"{i+1}. elem: {tomb[i]}");
            }
        }

    }
}
