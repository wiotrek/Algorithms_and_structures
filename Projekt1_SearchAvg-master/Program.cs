using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static int[] TestVector;

        static ulong OpComparisonEQ;
        const int NIter = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Size\tLAvgI\tLAvgT\tBAvgI\tBAvgT");
            for (int ArraySize = 50000; ArraySize <= 500000; ArraySize += 50000)
            {
                Console.Write(ArraySize);
                // tworzymy tablicę
                TestVector = new int[ArraySize];
                // wypełniamy tablicę
                for (int i = 0; i < TestVector.Length; ++i)
                    TestVector[i] = i;
                LinearAvgInstr(); // liniowe średnia instrumentacja
                LinearAvgTim(); // liniowe średnia czas
                BinaryAvgInstr(); // binarne średnia instrumentacja
                BinaryAvgTim(); // binarne średnia czas
                Console.Write("\n");
            }

            // Algorytm wyszukiwania
            static bool IsPresent_LinearTim(int[] Vector, int Number)
            {
                for (int i = 0; i < Vector.Length; i++)
                    if (Vector[i] == Number)
                        return true;
                return false;
            }
            static bool IsPresent_LinearInstr(int[] Vector, int Number)
            {
                for (int i = 0; i < Vector.Length; i++)
                {
                    OpComparisonEQ++;
                    if (Vector[i] == Number) return true;
                }
                return false;
            }

            static bool IsPresent_BinaryTim(int[] Vector, int Number)
            {
                int Left = 0, Right = Vector.Length - 1, Middle;
                while (Left <= Right)
                {
                    Middle = (Left + Right) / 2;
                    if (Vector[Middle] == Number) return true;
                    else if (Vector[Middle] > Number) Right = Middle - 1;
                    else Left = Middle + 1;
                }
                return false;
            }
            static bool IsPresent_BinaryInstr(int[] Vector, int Number)
            {
                int Left = 0, Right = Vector.Length - 1, Middle;
                while (Left <= Right)
                {
                    OpComparisonEQ++;
                    Middle = (Left + Right) / 2;
                    if (Vector[Middle] == Number) return true;
                    else
                    {
                        if (Vector[Middle] > Number) Right = Middle - 1;
                        else Left = Middle + 1;
                    }
                }
                return false;
            }




            //Wyszukiwanie Avg

            // Liniowe
            static void LinearAvgInstr()
            {
                OpComparisonEQ = 0;
                bool Present;
                for (int i = 0; i < TestVector.Length; ++i)
                    Present = IsPresent_LinearInstr(TestVector, i);
                Console.Write("\t" + ((double)OpComparisonEQ / (double)TestVector.Length).ToString("F1"));
            }
            static void LinearAvgTim()
            {
                double ElapsedSeconds;
                long ElapsedTime = 0, IterationElapsedTime, Avg = 0;
                for (int n = 0; n < (NIter + 1 + 1); ++n)
                {
                    long StartingTime = Stopwatch.GetTimestamp();
                    bool Present = IsPresent_LinearTim(TestVector, TestVector.Length - 1);
                    long EndingTime = Stopwatch.GetTimestamp();
                    IterationElapsedTime = EndingTime - StartingTime;
                    ElapsedTime += IterationElapsedTime;

                    if (n > 0) Avg = ElapsedTime / n;
                }
                ElapsedSeconds = Avg * (1.0 / (NIter * Stopwatch.Frequency));
                Console.Write("\t" + ElapsedSeconds.ToString("F8"));
            }

            //Binarne
            static void BinaryAvgInstr()
            {
                OpComparisonEQ = 0;
                bool Present;
                for (int i = 0; i < TestVector.Length; ++i)
                    Present = IsPresent_BinaryInstr(TestVector, i);
                Console.Write("\t" + ((double)OpComparisonEQ / (double)TestVector.Length).ToString("F1"));
            }
            static void BinaryAvgTim()
            {
                double ElapsedSeconds;
                long ElapsedTime = 0, IterationElapsedTime, Avg = 0;
                for (int n = 0; n < (NIter + 1 + 1); ++n)
                {
                    long StartingTime = Stopwatch.GetTimestamp();
                    bool Present = IsPresent_BinaryTim(TestVector, TestVector.Length);
                    long EndingTime = Stopwatch.GetTimestamp();
                    IterationElapsedTime = EndingTime - StartingTime;
                    ElapsedTime += IterationElapsedTime;
                    if (n > 0) Avg = ElapsedTime / n;
                }
                ElapsedSeconds = Avg * (1.0 / (NIter * Stopwatch.Frequency));
                Console.Write("\t" + ElapsedSeconds.ToString("F8"));
            }
        }
    }
}