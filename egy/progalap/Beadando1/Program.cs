using System;
namespace Beadando1
{
    class Program
    {
        static void Main(string[] args)
        {
            int faldarabok;
            int orsegek;
            string[] data = Console.ReadLine()!.Split(" ");
            int.TryParse(data[0], out faldarabok);
            int.TryParse(data[1], out orsegek);
            int[] arr = new int[faldarabok+1];
            for (int i = 0; i < orsegek; i++)
            {
                int be = int.Parse(Console.ReadLine()!);
                arr[be] = 1;
            }
           // Console.Error.WriteLine(String.Join(",", arr));
            int pivot = 0;
            int test = 0;
            for (int i = 0; i < faldarabok; i++)
            {
                if (arr[i] == 0 && arr[i + 1] == 0)
                {
                    if (i == pivot)
                    {
                        pivot++;
                    }
                    else
                    {
                        test++;
                        pivot = i+1;
                    }
                }
            }
            //Console.Error.WriteLine(pivot);
            if (pivot != faldarabok) {
                test++;
            }
            Console.WriteLine(test);
        }
    }
}
