using System;
using System.Diagnostics;

namespace Sortowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            // InsertionSort
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabAscending(i);
                long start = Stopwatch.GetTimestamp();
                InsertionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("InsertionSort: Rosnacy:{0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabDescending(i);
                long start = Stopwatch.GetTimestamp();
                InsertionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("InsertionSort: Malejacy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabRandom(i);
                long start = Stopwatch.GetTimestamp();
                InsertionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("InsertionSort: Losowy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabVShape(i);
                long start = Stopwatch.GetTimestamp();
                InsertionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("InsertionSort: V Ksztaltny: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabConst(i);
                long start = Stopwatch.GetTimestamp();
                InsertionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("InsertionSort: Staly: {0}; {1}", i, stop - start);
            }
            
            //CoctailSort
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabAscending(i);
                long start = Stopwatch.GetTimestamp();
                CocktailSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("CocktailSort: Rosnacy:{0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabDescending(i);
                long start = Stopwatch.GetTimestamp();
                CocktailSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("CocktailSort: Malejacy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabRandom(i);
                long start = Stopwatch.GetTimestamp();
                CocktailSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("CocktailSort: Losowy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabVShape(i);
                long start = Stopwatch.GetTimestamp();
                CocktailSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("CocktailSort: V Ksztaltny: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabConst(i);
                long start = Stopwatch.GetTimestamp();
                CocktailSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("CocktailSort: Staly: {0}; {1}", i, stop - start);
            }
            // SelectionSort
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabAscending(i);
                long start = Stopwatch.GetTimestamp();
                SelectionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("SelectionSort: Rosnacy:{0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabDescending(i);
                long start = Stopwatch.GetTimestamp();
                SelectionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("SelectionSort: Malejacy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabRandom(i);
                long start = Stopwatch.GetTimestamp();
                SelectionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("SelectionSort: Losowy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabVShape(i);
                long start = Stopwatch.GetTimestamp();
                SelectionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("SelectionSort: V Ksztaltny: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabConst(i);
                long start = Stopwatch.GetTimestamp();
                SelectionSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("SelectionSort: Staly: {0}; {1}", i, stop - start);
            }
            // HeapSort
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabAscending(i);
                long start = Stopwatch.GetTimestamp();
                HeapSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("HeapSort: Rosnacy:{0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabDescending(i);
                long start = Stopwatch.GetTimestamp();
                HeapSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("HeapSort: Malejacy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabRandom(i);
                long start = Stopwatch.GetTimestamp();
                HeapSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("HeapSort: Losowy: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabVShape(i);
                long start = Stopwatch.GetTimestamp();
                HeapSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("HeapSort: V Ksztaltny: {0}; {1}", i, stop - start);
            }
            for (int i = 50000; i <= 200000; i += 10000)
            {
                int[] tablica = tabConst(i);
                long start = Stopwatch.GetTimestamp();
                HeapSort(tablica);
                long stop = Stopwatch.GetTimestamp();
                Console.WriteLine("HeapSort: Staly: {0}; {1}", i, stop - start);
            }
            Console.ReadKey();
        }


        // GENERATORY TABLIC
        public static int[] tabAscending(int rozmiar)
        {
            int[] tab = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                tab[i] = i + 1;
            }
            return tab;
        }
        public static int[] tabDescending(int rozmiar)
        {
            int[] tab = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                tab[i] = rozmiar - i;
            }
            return tab;
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
        public static int[] tabVShape(int rozmiar)
        {
            int[] tablica = new int[rozmiar];
            int srodek = (int)rozmiar / 2;
            for (int i = 0; i < srodek; i++)
            {
                tablica[i] = (srodek - i) * 2;
            }
            for (int i = srodek; i < rozmiar; i++)
            {
                tablica[i] = (i - srodek) * 2 + 1;
            }
            return tablica;
        }
        public static int[] tabConst(int rozmiar)
        {
            int[] tab = new int[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {
                tab[i] = 23;
            }
            return tab;
        }


        // ALGORYTMY SORTOWANIA 
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i;
                int tmp = arr[j];

                while ((j > 0) && (arr[j - 1] > tmp))
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = tmp;
            }
        }
        public static void CocktailSort(int[] arr)
        {
            int left = 1, right = arr.Length - 1, k = arr.Length - 1;
            do
            {
                for (int j = right; j >= left; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                        k = j;
                    }
                }

                left = k + 1;

                for (int j = left; j <= right; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                        k = j;
                    }
                }
                right = k - 1;
            } while (left <= right);
        }
        public static void SelectionSort(int[] arr)
        {
            int k;
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                int tmp = arr[i];
                k = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < tmp)
                    {
                        k = j;
                        tmp = arr[j];
                    }

                arr[k] = arr[i];
                arr[i] = tmp;
            }
        }
        public static void Heapify(int[] t, int left, int right)
        {
            int i = left, j = 2 * i + 1;
            int buf = t[i];

            while (j <= right)
            {
                if (j < right)
                    if (t[j] < t[j + 1])
                        j++;
                if (buf >= t[j]) break;

                t[i] = t[j];
                i = j;
                j = 2 * i + 1;
            }

            t[i] = buf;
        }

        public static void HeapSort(int[] arr)
        {
            int left = (int)arr.Length / 2;
            int right = (int)arr.Length - 1;
            while (left > 0)
            {
                left--;
                Heapify(arr, left, right);
            }

            while (right > 0)
            {
                int buf = arr[left];
                arr[left] = arr[right];
                arr[right] = buf;
                right--;
                Heapify(arr, left, right);
            }
        }
    }
}
