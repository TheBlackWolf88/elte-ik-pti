// Bekovics Dániel - G9E74R
namespace Zh
{
    class Program
    {
        struct Day {
            public int be;
            public int ki;
            public int marad;
        }
        public static void Main (string[] args){
            const int MaxN = 100;
            int N;
            do {
                System.Console.Error.WriteLine("db: ");
            }
            while (!int.TryParse(Console.ReadLine(), out N) && N > MaxN && 1 > N);
            //ez itt miert nem jo? csak a tipust teszteli a masik kettot meg figyelmen kivul hagyja

            Day[] stat = new Day[N];

            for (int i = 0; i < N; i++){
                //be ki marad
                Console.Error.WriteLine((i+1) + ". adat(be ki marad):"); 
                string[] line = Console.ReadLine()!.Split(" ");
                int.TryParse(line[0], out stat[i].be);
                int.TryParse(line[1], out stat[i].ki);
                int.TryParse(line[2], out stat[i].marad);
                if (stat[i].be <= 0 && stat[i].ki <= 0 && stat[i].marad <= 0) {
                    //Elvileg ugyanarra az iteraciora dobja vissza, ha nem felel meg az elofeltetelnek.
                    i--;
                }
            }

            int hanyTobb100;
            int osszVendeg;
            int minHazaDb;
           

            hanyTobb100 = calcHany(stat, N);
            osszVendeg = calcOssz(stat, N);
            int nKi = calcNki(stat, N);
            minHazaDb = calcMinH(stat, N, nKi);

            int[] minHaza = szeddKi(stat, N, minHazaDb, nKi);

            System.Console.WriteLine("hanyTobb100=" + hanyTobb100);
            System.Console.WriteLine("osszVendeg=" + osszVendeg);
            System.Console.WriteLine("minHazaDb=" + minHazaDb);
            System.Console.WriteLine("minHaza=" + String.Join(" ", minHaza));


            

        }

        static int[] szeddKi(Day[] stat, int n, int minHazaDb, int nKi)
        {
            int[] arr = new int[minHazaDb];
            int j = 0;
            for (int i = 0; i < n; i++){
                if (stat[i].ki == nKi) {
                    arr[j] = i+1;
                    j++;
                }
            }

            return arr;
        }

        static int calcHany(Day[] stat, int N){
            int a = 0;
            for(int i = 0; i < N; i++){
                if (stat[i].be > 100) a++;
            }

            return a;

        }
        static int calcOssz(Day[] stat, int N){
            int a = 0;
            for (int i = 0; i < N; i++)
            {
                a += stat[i].be;
            }
            return a;
        }

        static int calcNki(Day[] stat, int N){

            int nKi = 3000;
            for (int i = 0; i < N; i++)
            {
                if(stat[i].ki < nKi){
                    nKi = stat[i].ki;
                }
            }
            return nKi;
        }

        static int calcMinH(Day[] stat, int N, int nKi){
            int a = 0;
            for (int i = 0; i < N; i++)
            {
                if(stat[i].ki < nKi){
                    nKi = stat[i].ki;
                    a = 0;
                }
                if(stat[i].ki == nKi){
                    a++;
                }
            }
            return a;
        }
    }
}
