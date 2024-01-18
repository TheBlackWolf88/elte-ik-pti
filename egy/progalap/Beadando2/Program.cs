using System;

namespace Beadando2
{
    struct Lakas
    {
        public int T;
        public int A;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            int N;
            int.TryParse(Console.ReadLine()!, out N);

            Lakas[] dat = new Lakas[N];

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine()!.Split(" ");
                int.TryParse(line[0], out dat[i].T);
                int.TryParse(line[1], out dat[i].A);
            }
            int cTeruletek = 0;
            for (int i = 0; i < N; i++)
            {
                if (!voltBenne(i, dat)) cTeruletek++;
            }

            System.Console.WriteLine(cTeruletek);
        }

        static bool voltBenne(int i, Lakas[] dat)
        {
            bool voltBenne = false;
            int j = 0;
            while (j < i && !voltBenne)
            {
                if (dat[j].T != dat[i].T)
                {
                    j++;
                } else {
                    voltBenne = true;
                }
            }
            return voltBenne;
        }
    }
}
