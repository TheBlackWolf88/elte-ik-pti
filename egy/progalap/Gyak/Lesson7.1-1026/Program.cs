using System;
namespace Lesson7_1
{
    class Program
    {
        struct DailyTemp
        {
            public int min;
            public int max;
        }

        public static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine()!, out n);
            DailyTemp[] a = new DailyTemp[n];
            for (int i = 0; i < n; i++)
            {
                string[] inp = Console.ReadLine()!.Split(" ");
                a[i].min = int.Parse(inp[0]);
                a[i].max = int.Parse(inp[1]);
            }


            int cFagyi = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i].min <= 0) cFagyi++;
            }
            Console.WriteLine("#");
            Console.WriteLine(cFagyi);

            int maxHoingas = 0;
            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(a[i].min - a[i].max) > Math.Abs(a[maxHoingas].min - a[maxHoingas].max))
                {
                    maxHoingas = i;
                }
            }
            Console.WriteLine("#");
            Console.WriteLine(maxHoingas+1);
            int letminimum = -1;

            int k = 1;

            while(letminimum == -1 && k < n){
                if(a[k-1].min > a[k].max){
                    letminimum = k;
                }
                k++;
            }

            Console.WriteLine("#");
            if(letminimum == -1){
                Console.WriteLine(letminimum);
            } else {
                Console.WriteLine(letminimum+1);
            }

            int cFagyOl =0;

            for(int i = 0; i < n; i++){
                if(a[i].min <= 0 && a[i].max > 0){
                    cFagyOl++;
                }
            }

            int[] fagyOl = new int[cFagyOl];
            int j = 0;
            for(int i = 0; i < n; i++){
                if(a[i].min <= 0 && a[i].max > 0){
                        fagyOl[j] = i+1;
                        j++;
                }
            }
            Console.WriteLine("#");
            Console.WriteLine(cFagyOl + " " + String.Join(" ", fagyOl));





        }
    }
}
