using System;
using System.Numerics;
using System.Diagnostics;

namespace LiczbyPierwsze
{
    class Program
    {
        public static BigInteger[] primeNumber = { 1619, 1009140613399 };
        static BigInteger OpComparisonEQ;

        static void Main(string[] args)
        {
            Console.WriteLine("\tnumber \tisPrime? \texampleTime \texampleInstr \tBetterisPrime? \tbetterTime \tbetterInstr");
            foreach (BigInteger item in primeNumber)
            {
                exampleTime(item);
                exampleInstr(item);
                betterTime(item);
                betterInstr(item);

            }
            Console.Write("\n");

        }

        // Algorytm sprawdzający czy liczba jest pierwsza - Algorytm przykładowy
        public static bool isPrime_exampleTime(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else for (BigInteger u = 3; u < Num / 2; u += 2)
                    if (Num % u == 0) return false;

            return true;
        }
        // Algorytm sprawdzajacy czy liczba jest pierwsza - Instrumentacja algorytm przykładowy
        public static bool isPrime_exampleInstr(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else for (BigInteger u = 3; u < Num / 2; u += 2)
                {
                    ++OpComparisonEQ;
                    if (Num % u == 0) return false;
                }
                    

            return true;
        }
        // funkcja mierząca czas potrzebny do sprawdzenia czy liczba jest pierwsza - algorytmu przykładowego
        static void exampleTime(BigInteger Num)
        {
            double ElapsedSeconds = 0;
            long StartingTime = Stopwatch.GetTimestamp();
            bool isPrimeisTrue = isPrime_exampleTime(Num);
            long EndingTime = Stopwatch.GetTimestamp();
            
            long ElapsedTime = EndingTime - StartingTime;
            ElapsedSeconds = ElapsedTime * (1.0 / Stopwatch.Frequency);

            Console.Write(Num+"\t"+isPrimeisTrue+"\t"+ElapsedSeconds.ToString("F4"));
        }
        // funkcja mierząca ilosc powtórzeń potrzebnych do sprawdzenia czy liczba jest pierwsza - algorytmu przykładowego
        static void exampleInstr(BigInteger Num)
        {
            OpComparisonEQ = 1;
            bool isPrimeisTrue = isPrime_exampleInstr(Num);

            Console.Write("\t" + OpComparisonEQ+"\t");
        }

        // Algorytm sprawdzający czy liczba jest pierwsza - Algorytm ulepszony
        public static bool isPrime_betterTime(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            for (BigInteger i = 3; i * i <= Num; i+=2)
            {
                if (Num % i == 0) return false;
            }
            return true;  
        }
        // Algorytm sprawdzający czy liczba jest pierwsza - instrumentacja algorytmu ulepszonego
        public static bool isPrime_betterInstr(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            for (BigInteger i = 3; i * i  <= Num ; i+=2)
            {
                OpComparisonEQ++;
                if (Num % i == 0) return false;
            }
            return true;
        }
        static void betterTime(BigInteger Num)
        {
            double ElapsedSeconds = 0;
            long StartingTime = Stopwatch.GetTimestamp();
            bool isPrimeisTrue = isPrime_betterTime(Num);
            long EndingTime = Stopwatch.GetTimestamp();

            long ElapsedTime = EndingTime - StartingTime;
            ElapsedSeconds = ElapsedTime * (1.0 / Stopwatch.Frequency);

            Console.Write("\t" + isPrimeisTrue + "\t" + ElapsedSeconds.ToString("F4"));
        }
        // Algorytm sprawdzający ilość powtórzeń potrzebnych do sprawdzenia czy liczba jest pierwsza - Algorytm ulepszony
        static void betterInstr(BigInteger Num)
        {
            OpComparisonEQ = 1;
            bool isPrimeisTrue = isPrime_betterInstr(Num);

            Console.WriteLine("\t" + OpComparisonEQ);
        }
    }
}
