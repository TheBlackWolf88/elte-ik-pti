using System;
using System.Collections.Generic;
namespace Beadando
{
    class Program
    {
        public static void Main(string[] args)
        {
            int N;
            int[] diffsMax;
            beolvas(out N, out diffsMax);
            int max = getMax(diffsMax, N);
            int cTemp;
            List<int> kivalasztottak;
            kivalogat(N, diffsMax, max, out cTemp, out kivalasztottak);
            kiir(cTemp, kivalasztottak);

        }

        static int getMax(int[] arr, int N)
        {
            int max = arr[0];
            for (int i = 1; i < N; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        static void beolvas(out int N, out int[] diffsMax)
        {
            if (Console.IsInputRedirected)
            {
                int M;
                string[] fline = Console.ReadLine()!.Split(" ");
                int.TryParse(fline[0], out N);
                int.TryParse(fline[1], out M);
                diffsMax = new int[N];
                for (int i = 0; i < N; i++)
                {
                    string[] line = Console.ReadLine()!.Split(" ");
                    int[] sor = new int[M];
                    for (int j = 0; j < M; j++)
                    {
                        sor[j] = int.Parse(line[j]);
                    }
                    int[] diffs = new int[M];
                    int k = 0;
                    for (int j = 1; j < M; j++)
                    {
                        diffs[k] = Math.Abs(sor[j] - sor[j - 1]);
                        k++;
                    }
                    diffsMax[i] = getMax(diffs, M);

                }
            }
            else
            {
                bool jo;
                do
                {
                    System.Console.Write("Települések száma = ");
                    jo = int.TryParse(Console.ReadLine()!, out N);
                    jo = jo && N >= 1;
                    if (!jo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("0-nál nagyobb természetes szám kell!");
                        Console.ResetColor();
                    }
                }
                while (!jo);

                int M;
                do
                {
                    System.Console.Write("Napok száma = ");
                    jo = int.TryParse(Console.ReadLine()!, out M);
                    jo = jo && M >= 1;
                    if (!jo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("0-nál nagyobb természetes szám kell!");
                        Console.ResetColor();
                    }
                } while (!jo);
                diffsMax = new int[N];
                for (int i = 0; i < N; i++)
                {
                    int[] sor = new int[M];
                    for (int j = 0; j < M; j++)
                    {
                        do
                        {

                            System.Console.Write((i + 1) + ". telepulés " + (j + 1) + ". napján mért legnagyobb hőmérséklet = ");
                            jo = int.TryParse(Console.ReadLine()!, out sor[j]);
                            jo = jo && sor[j] >= -50 && sor[j] <= 50;
                            if (!jo)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.WriteLine("-50 és 50 közötti egész szám kell! (A negatívak egybeirandók!)");
                                Console.ResetColor();

                            }
                        } while (!jo);
                    }
                    int[] diffs = new int[M];
                    int k = 0;
                    for (int j = 1; j < M; j++)
                    {
                        diffs[k] = Math.Abs(sor[j] - sor[j - 1]);
                        k++;
                    }
                    diffsMax[i] = getMax(diffs, M);
                }
            }
        }
        static void kivalogat(int N, int[] diffsMax, int max, out int cTemp, out List<int> kivalasztottak)
        {
            cTemp = 0;
            kivalasztottak = new List<int>();

            for (int i = 0; i < N; i++)
            {
                if (diffsMax[i] == max)
                {
                    cTemp++;
                    kivalasztottak.Add(i + 1);
                }
            }
        }

        static void kiir(int cTemp, List<int> kivalasztottak)
        {
            if (Console.IsOutputRedirected)
            {
                System.Console.WriteLine(cTemp + " " + String.Join(" ", kivalasztottak));
            }
            else
            {
                System.Console.WriteLine(cTemp + " db településen lesz egyik napról a másikra nagy hőmérséklet változás, melyek a következő sorszámúak: " + String.Join(", ", kivalasztottak));
            }
        }

    }

}
