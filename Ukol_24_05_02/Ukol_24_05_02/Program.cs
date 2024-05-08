using System;
using System.Collections.Generic;

namespace Ukol_24_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

            Console.WriteLine("1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine();

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.

            Console.WriteLine("2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.");
            DateTime mojeDatumNarozeni = new DateTime(1991, 6, 20);

            TimeSpan pocetDni = DateTime.Now - mojeDatumNarozeni;
            Console.WriteLine($"Jsem tu už {pocetDni.Days} dní!");
            Console.WriteLine();

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

            Console.WriteLine("3. Vytvoř list stringů a vlož do něj 5 různých hodnot.");
            List<string> nakupniSeznam = new List<string>() { "jablko", "pomeranč", "citron", "jahoda", "meloun" };

            Console.WriteLine($"Mám nakoupit: {string.Join(", ", nakupniSeznam)}.");
            Console.WriteLine();

            // 4. Smaž z tohoto listu libovolnou hodnotu.

            Console.WriteLine("4. Smaž z tohoto listu libovolnou hodnotu.");
            nakupniSeznam.RemoveAt(1);
            Console.WriteLine(string.Join(", ", nakupniSeznam));
            Console.WriteLine();

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

            Console.WriteLine("5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains");
            if (nakupniSeznam.Contains("pomeranč"))
            {
                Console.WriteLine("Ano, nákupní seznam obsahuje POMERANČ.");
            }
            else
            {
                Console.WriteLine("Ne, nákupní seznam neobsahuje POMERANČ");
            }
            Console.WriteLine();

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

            Console.WriteLine("6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: \"2: modra, zelena\").");
            int pocetPolozek = nakupniSeznam.Count;
            Console.WriteLine($"V listu Nákupní seznam jsou {pocetPolozek} položky: {string.Join(", ", nakupniSeznam)}");
            Console.WriteLine();

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

            Console.WriteLine("7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <\"chleba\", 20>).");
            Dictionary<string, int> nakupniSeznamSlovnik = new Dictionary<string, int>();
            int cena = 5;

            for (int i = pocetPolozek - 1; i >= 0; i--)
            {
                string vec = nakupniSeznam[i];
                nakupniSeznamSlovnik[vec] = cena++;
            }
            foreach (var vec in nakupniSeznamSlovnik)
            {
                Console.WriteLine($"Položka {vec.Key} stojí {vec.Value}");
            }
            Console.WriteLine();

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

            Console.WriteLine("8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.");


            if (nakupniSeznamSlovnik.ContainsKey("jablko"))
            {
                Console.WriteLine($"Ano, nákupní seznam obsahuje JABLKO a jeho cena je {nakupniSeznamSlovnik["jablko"]}.");
            }
            else
            {
                Console.WriteLine("Ne, nákupní seznam neobsahuje JABLKO");
            }
            Console.WriteLine();

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.

            Console.WriteLine("9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.");
            nakupniSeznamSlovnik["jablko"] = nakupniSeznamSlovnik["jablko"] * 2;

            foreach (var vec in nakupniSeznamSlovnik)
            {
                Console.WriteLine($"Položka {vec.Key} stojí {vec.Value}");
            }
            Console.WriteLine();
        }
    }
}
