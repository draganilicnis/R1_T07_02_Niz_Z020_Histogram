// https://petlja.org/sr-Latn-RS/kurs/17862/33/2763
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/histogram
// C#: 
// PAS: https://github.com/draganilicnis/R1_T07_02_Niz_Z020_Histogram/blob/main/Histogram.pas
// C#:  https://onlinegdb.com/Y4qELAJcC
// PAS: https://onlinegdb.com/BAZi2ruSKg
// 1 WA (7. test primer)

using System;

class R1_T07_02_Niz_Histogram_01_WA_2025_Ver_001
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();        // Ucitavamo granice intervala
        double a = double.Parse(s[0]);                  // a => OD => Pocetak intervala [a, b)
        double b = double.Parse(s[1]);                  // b => DO => Kraj intervala    [a, b)

        int n = int.Parse(Console.ReadLine());          // Ucitavamo broj podeoka
        double dx = (b - a) / n;                        // Izracunavamo sirinu jednog podeoka (svaki podeok je iste sirine)
        int[] histogram = new int[n];                   // Histogram cuva broj tacaka u svakom podeoku

        int k = int.Parse(Console.ReadLine());          // Ucitavamo ukupan broj tacaka (zaba)
        for (int i = 0; i < k; i++)
        {
            double x = double.Parse(Console.ReadLine());// Ucitavamo sledecu tacku (odnosno velicinu zabe)
            int podeok = (int)((x - a) / dx);           // Odredjujemo podeok kojem ona pripada
            histogram[podeok]++;                        // Uvecavamo broj tacaka u tom podeoku histograma
        }

        // Ispisujemo histogram
        double t = a;
        for (int i = 0; i < n; i++)
        {
            double l = t;
            double d = t + dx;
            Console.Write("[" + l.ToString("F3") + ", " + d.ToString("F3") + "): ");    // Ispisujemo granice tekuceg podeoka (zaokruzene na tri doublee)
            Console.Write(histogram[i] + "\t");                                         // Ispisujemo broj tacaka u tekucem podeoku

            // Ispisujemo zvezdice
            double procenat = (double)histogram[i] / (double)k;
            int brojZvezdica = (int)Math.Round(100 * procenat, MidpointRounding.AwayFromZero);
            for (int z = 0; z < brojZvezdica; z++) Console.Write("*");
            Console.WriteLine();
            t = t + dx;        // Prelazimo na naredni podeok
        }
    }
}






// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/histogram
// https://arena.petlja.org/competition/r1-07-nizovi-05-preslikavanja#tab_132994
// https://arena.petlja.org/competition/r1-07-nizovi-04-vektori-polinomi#tab_132710
// https://arena.petlja.org/competition/skola-od-kuce-nizovi1-zadaci#tab_97594
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#BFormatString
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
// https://github.com/draganilicnis/R1_T07_02_Niz_Z020_Histogram/blob/main/R1_T07_02_Niz_Z020_Histogram.cs

/*
using System.Globalization;     // Zbog kulture koja je nezavisna od jezika ili regiona i koristi se za standardizovano formatiranje i parsiranje podataka
using System.Threading;         // Zbog kulture da bi vazila za ceo program, osim ako se pokrenu novi tokovi

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;     // Kultura je nezavisna od jezika ili regiona i koristi se za standardizovano formatiranje i parsiranje podataka brojeva i datuma
        // Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;   // za tekstualne podatke

        Histogram();
        // Real_double_Zaokruzivanje();
    }

    static void Histogram()
    {
        string[] s = Console.ReadLine().Split();        // Ucitavamo granice intervala
        double a = double.Parse(s[0]);                    // double a = double.Parse(s[0], CultureInfo.InvariantCulture);
        double b = double.Parse(s[1]);                    // double b = double.Parse(s[1], CultureInfo.InvariantCulture);

        int n = int.Parse(Console.ReadLine());          // Ucitavamo broj podeoka
        double dx = (b - a) / n;                         // Izracunavamo sirinu jednog podeoka
        int[] histogram = new int[n];                   // Histogram cuva broj tacaka u svakom podeoku
        
        int k = int.Parse(Console.ReadLine());          // Ucitavamo ukupan broj tacaka
        for (int i = 0; i < k; i++)
        {
            double x = double.Parse(Console.ReadLine());  // Ucitavamo sledecu tacku
            int podeok = (int)((x - a) / dx);           // Odredjujemo podeok kojem ona pripada
            histogram[podeok]++;                        // Uvecavamo broj tacaka u tom podeoku histograma
        }

        // Ispisujemo histogram
        double t = a;
        for (int i = 0; i < n; i++)
        {
            // Console.Write("[" + t.ToString("F3") + ", " + (t + dx).ToString("F3") + "): ");          // Ispisujemo granice tekuceg podeoka (zaokruzene na tri doublee)
            // Zbog ispisa, odnosno zaokruzivanja na 3 doublee
            // double l = Math.Floor(t * 10000) / 10000;
            // double d = Math.Floor((t + dx) * 10000) / 10000;
            double l = t;
            double d = t + dx;
            Console.Write("[" + l.ToString("F3") + ", " + d.ToString("F3") + "): ");                    // Ispisujemo granice tekuceg podeoka (zaokruzene na tri doublee)
            // Console.Write("[" + l.ToString("F3", CultureInfo.InvariantCulture) + ", " + d.ToString("F3", CultureInfo.InvariantCulture) + "): ");                    // Ispisujemo granice tekuceg podeoka (zaokruzene na tri doublee)

            Console.Write(histogram[i] + "\t");                                                         // Ispisujemo broj tacaka u tekucem podeoku

            // Ispisujemo zvezdice
            double procenat = (double)histogram[i] / (double)k;
            int brojZvezdica = (int)Math.Round(100 * procenat, MidpointRounding.AwayFromZero);
            for (int z = 0; z < brojZvezdica; z++) Console.Write("*");
            Console.WriteLine();
            t = t + dx;        // Prelazimo na naredni podeok
        }
    }

static void Real_double_Zaokruzivanje()
{
    // Console.InputEncoding = System.Text.Encoding.Unicode;    // Nije potrebno - nema efekta u ovom zadatku
    // Console.OutputEncoding = System.Text.Encoding.Unicode;   // Nije potrebno - nema efekta u ovom zadatku    
    // WA 1 Test primer 6
    // double[] Test_Primer_6_OUT = new double[8 + 1];
    double[] Test_Primer_6_OUT = { 8.230, 8.586, 8.942, 9.299, 9.655, 10.011, 10.367, 10.724, 11.080 };
    double a = 8.23;       // double a = double.Parse(s[0]);
    double b = 11.08;       // double b = double.Parse(s[1]);
    int n = 8;              // int n = int.Parse(Console.ReadLine());
    double dx = (b - a) / n;
    Console.WriteLine(dx);
    Console.WriteLine("   " + a.ToString("00.000"));
    CultureInfo ci = new CultureInfo("en-us");
    double t = a;
    for (int i = 0; i < n; i++)
    {
        t = t + dx;
        // Console.WriteLine(t);
        Console.Write(i + ". " + Test_Primer_6_OUT[i + 1].ToString("00.000") + ": ");
        Console.Write(t.ToString("00.000") + " " + t.ToString("00.0000") + " " + t.ToString("00.00000") + " ");
        Console.Write(t.ToString("F3" + " "));
        Console.Write(t.ToString("F3", CultureInfo.InvariantCulture) + " ");
        Console.Write(t.ToString("F3", ci) + " ");
        Console.Write(t.ToString("N3") + " ");
        double p = Math.Floor(t * 10000) / 10000;
        Console.Write(p.ToString("00.000") + " ");
        Console.Write(t);
        Console.WriteLine();
    }
}
*/
