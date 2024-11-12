// https://petlja.org/sr-Latn-RS/kurs/14606/33/2763
// https://petlja.org/biblioteka/r/problemi/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka-stara/histogram
// https://arena.petlja.org/competition/r1-07-nizovi-05-preslikavanja#tab_132994
// https://arena.petlja.org/competition/r1-07-nizovi-04-vektori-polinomi#tab_132710
// https://arena.petlja.org/competition/skola-od-kuce-nizovi1-zadaci#tab_97594
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#BFormatString
// https://github.com/draganilicnis/R1_T07_02_Niz_Z020_Histogram/blob/main/R1_T07_02_Niz_Z020_Histogram.cs
// 1 WA

using System;

class R1_T07_02_Niz_Z020_Histogram_01_WA_Ver_000
{
    static void Main()
    {
        string[] s = Console.ReadLine().Split();            // Ucitavamo granice intervala
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        
        int n = int.Parse(Console.ReadLine());              // Ucitavamo broj podeoka
        double dx = (b - a) / n;                            // Izracunavamo sirinu jednog podeoka
        int[] histogram = new int[n];                       // Histogram cuva broj tacaka u svakom podeoku

        int k = int.Parse(Console.ReadLine());              // Ucitavamo ukupan broj tacaka
        for (int i = 0; i < k; i++)
        {
            double x = double.Parse(Console.ReadLine());    // Ucitavamo sledecu tacku
            int podeok = (int)((x - a) / dx);               // Odredjujemo podeok kojem ona pripada
            histogram[podeok]++;                            // Uvecavamo broj tacaka u tom podeoku histograma
        }

        // Ispisujemo histogram
        double t = a;
        for (int i = 0; i < n; i++)
        {
            Console.Write("[" + t.ToString("F3") + ", " + (t + dx).ToString("F3") + "): ");             // Ispisujemo granice tekuceg podeoka (zaokruzene na tri decimale)
            Console.Write(histogram[i] + "\t");                                                         // Ispisujemo broj tacaka u tekucem podeoku
            // Ispisujemo zvezdice
            double procenat = (double)histogram[i] / (double)k;
            int brojZvezdica = (int)Math.Round(100 * procenat);
            for (int z = 0; z < brojZvezdica; z++) Console.Write("*");
            Console.WriteLine();
            t = t + dx;        // Prelazimo na naredni podeok
        }
    }
}
