// https://petlja.org/sr-Latn-RS/kurs/14606/33/2763
// https://petlja.org/biblioteka/r/problemi/Zbirka/histogram
// https://petlja.org/biblioteka/r/problemi/Zbirka-stara/histogram
// https://arena.petlja.org/competition/r1-07-nizovi-05-preslikavanja#tab_132994
// https://arena.petlja.org/competition/r1-07-nizovi-04-vektori-polinomi#tab_132710
// https://arena.petlja.org/competition/skola-od-kuce-nizovi1-zadaci#tab_97594

using System;

class Program
{
    static void Main()
    {
        // ucitavamo granice intervala
        string[] str = Console.ReadLine().Split();
        double a = double.Parse(str[0]);
        double b = double.Parse(str[1]);
        // ucitavamo broj podeoka
        int n = int.Parse(Console.ReadLine());
        // izracunavamo sirinu jednog podeoka
        double dx = (b - a) / n;
        // histogram cuva broj tacaka u svakom podeoku
        int[] histogram = new int[n];
        // ucitavamo ukupan broj tacaka
        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
        {
            // ucitavamo sledecu tacku
            double x = double.Parse(Console.ReadLine());
            // odredjujemo podeok kojem ona pripada
            int podeok = (int)((x - a) / dx);
            // uvecavamo broj tacaka u tom podeoku histograma
            histogram[podeok]++;
        }
        // ispisujemo histogram
        double t = a;
        foreach (int h in histogram)
        {
            // ispisujemo granice tekuceg podeoka (zaokruzene na tri decimale)
            Console.Write("[" + t.ToString("0.000") + ", " +
                          (t + dx).ToString("0.000") + "): ");
            // ispisujemo broj tacaka u tekucem podeoku
            Console.Write(h + "\t");
            // ispisujemo zvezdice
            double procenat = (double)h / (double)k;
            int brojZvezdica = (int)Math.Round(100 * procenat);
            for (int i = 0; i < brojZvezdica; i++)
                Console.Write("*");
            Console.WriteLine();
            // prelazimo na naredni podeok
            t += dx;
        }
    }
}
