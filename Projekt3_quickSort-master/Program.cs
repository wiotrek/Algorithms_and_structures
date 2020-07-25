using System;
using System.Diagnostics;
using System.Threading;

namespace QuickSort
{
    class Program
    {
        static void Tester()
        {
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabRandom(i);
                long start = Stopwatch.GetTimestamp();
                QuickSortIteration(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("QuickSortIteration Losowy {0} {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabRandom(i);
                long start = Stopwatch.GetTimestamp();
                QuickSortRecursion(tablica, 0, tablica.Length - 1);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("QuickSortRecursion Losowy {0} {1}", i, stop - start);
            }


            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabAShape(i);
                long start = Stopwatch.GetTimestamp();
                QuickSortRecursionRandomPivot(tablica, 0, tablica.Length - 1);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("RadnomPivot Aksztaltna {0} {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabAShape(i);
                long start = Stopwatch.GetTimestamp();
                QuickSortRecursionLastPivot(tablica, 0, tablica.Length - 1);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("LastPivot Aksztaltna {0} {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabAShape(i);
                long start = Stopwatch.GetTimestamp();
                QuickSortRecursion(tablica, 0, tablica.Length - 1);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("MiddlePivot Aksztaltna {0} {1}", i, stop - start);
            }
        }
        static void Main(string[] args)
        {
            Thread TesterThread = new Thread(Program.Tester, 8 * 1024 * 1024); // utworzenie wątku
            TesterThread.Start(); // uruchomienie wątku
            TesterThread.Join(); // oczekiwanie na zakończenie wątku
        }
        // Tablice
        public static int[] tabAShape (int size)
        {
            int[] arr = new int[size];
            int center = (int)size / 2;
            for (int i = 0; i < center; i++)
            {
                arr[i] = i * 2 + 2;
            }
            for (int i = center; i < size; i++)
            {
                arr[i] = (size - i) * 2 - 1;
            }
            return arr;
        }


        public static int[] tabRandom(int rozmiar)
        {
            int[] tablica = new int[rozmiar];
            Random rand = new Random();
            for (int i = 0; i < rozmiar; i++)
            {
                tablica[i] = rand.Next(1, rozmiar + 1);
            }
            return tablica;
        }


        // Algorytmy Sortowania

        // sorotwanie szybkie iterracyjne
        public static void QuickSortIteration(int[] t)
        {
            int i, j, l, p, sp;
            int[] stos_l = new int[t.Length],
            stos_p = new int[t.Length]; // przechowywanie żądań podziału
            sp = 0; 
            stos_l[sp] = 0; 
            stos_p[sp] = t.Length - 1; // rozpoczynamy od całej tablicy
            do
            {
                l = stos_l[sp]; p = stos_p[sp]; sp--; // pobieramy żądanie podziału
                do
                {
                    int x;
                    i = l; j = p; x = t[(l + p) / 2]; // analogicznie do wersji rekurencyjnej
                    do
                    {
                        while (t[i] < x) i++;
                        while (x < t[j]) j--;
                        if (i <= j)
                        {
                            int buf = t[i]; t[i] = t[j]; t[j] = buf;
                            i++; j--;
                        }
                    } while (i <= j);
                    if (i < p) { sp++; stos_l[sp] = i; stos_p[sp] = p; } // ewentualnie dodajemy żądanie podziału
                    p = j;
                } while (l < p);
            } while (sp >= 0); // dopóki stos żądań nie będzie pusty
        }
        // Sortowanie szybkie rekurencyjne srodkowe polozenie pivota
        public static void QuickSortRecursion(int[] t, int l, int p)
        {
            int i, j, x;
            i = l;
            j = p;
            x = t[(l + p) / 2]; // (pseudo)mediana
            do
            {
                while (t[i] < x) i++; // przesuwamy indeksy z lewej
                while (x < t[j]) j--; // przesuwamy indeksy z prawej
                if (i <= j) // jeśli nie minęliśmy się indeksami (koniec kroku)
                { // zamieniamy elementy
                    int buf = t[i]; t[i] = t[j]; t[j] = buf;
                    i++; j--;
                }
            }
            while (i <= j);
            if (l < j) QuickSortRecursion(t, l, j); // sortujemy lewą część (jeśli jest)
            if (i < p) QuickSortRecursion(t, i, p); // sortujemy prawą część (jeśli jest)
        }
        // Sortowanie szybkie pivot na ostatnim miejscu
        public static void QuickSortRecursionLastPivot(int[] t, int l, int p)
        {
            int i, j, x;
            i = l;
            j = p;
            x = t[p]; // (pseudo)mediana
            do
            {
                while (t[i] < x) i++; // przesuwamy indeksy z lewej
                while (x < t[j]) j--; // przesuwamy indeksy z prawej
                if (i <= j) // jeśli nie minęliśmy się indeksami (koniec kroku)
                { // zamieniamy elementy
                    int buf = t[i]; t[i] = t[j]; t[j] = buf;
                    i++; j--;
                }
            }
            while (i <= j);
            if (l < j) QuickSortRecursion(t, l, j); // sortujemy lewą część (jeśli jest)
            if (i < p) QuickSortRecursion(t, i, p); // sortujemy prawą część (jeśli jest)
        }
        // Sortowanie szybkie pivot losowy
        public static void QuickSortRecursionRandomPivot(int[] t, int l, int p)
        {
            int i, j, x;
            i = l;
            j = p;
            x = t[new Random().Next(l, p)]; // (pseudo)mediana
            do
            {
                while (t[i] < x) i++; // przesuwamy indeksy z lewej
                while (x < t[j]) j--; // przesuwamy indeksy z prawej
                if (i <= j) // jeśli nie minęliśmy się indeksami (koniec kroku)
                { // zamieniamy elementy
                    int buf = t[i]; t[i] = t[j]; t[j] = buf;
                    i++; j--;
                }
            }
            while (i <= j);
            if (l < j) QuickSortRecursion(t, l, j); // sortujemy lewą część (jeśli jest)
            if (i < p) QuickSortRecursion(t, i, p); // sortujemy prawą część (jeśli jest)
        }
    }
}
