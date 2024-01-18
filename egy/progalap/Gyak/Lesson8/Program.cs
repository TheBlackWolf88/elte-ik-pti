using System;
namespace Lesson8
{
    class Program {
        public static void Main(string[] args){
            int N;
            int M;
            string[] line = Console.ReadLine()!.Split(" ");
            int.TryParse(line[0], out N);
            int.TryParse(line[1], out M);
            int[] diffs = new int[M];
            int[] ut = new int[N];
            for(int i = 0; i < M; i++){
                line = Console.ReadLine()!.Split(" ");
                diffs[i] = int.Parse(line[1]) - int.Parse(line[0]);
                for(int j = int.Parse(line[0]); j < int.Parse(line[1]); j++){
                    ut[j]++;
                }
            }

            int minF = diffs[0];
            for(int i = 1; i < M; i++){
                if (diffs[i] < minF){
                    minF = diffs[i];
                }
            }

            Console.WriteLine(minF);

            int haromszor = 0;
            bool van1 = false;

            while (!van1 && haromszor < N) {
                if(ut[haromszor] == 3){
                    van1 = true;
                } else {
                    haromszor++;
                }
            }
            if (!van1) haromszor = -1;

            System.Console.WriteLine(haromszor);

            int kellMeg = 0;
            for(int i = 0; i < N; i++){
                if(ut[i] == 0){
                    kellMeg++;
                }
            }

            System.Console.WriteLine(kellMeg);

            int maxHossz = 0;
            int hossz = 0;
            for(int i = 0; i < N; i++){
                if(ut[i] != 0) {
                    if(hossz > maxHossz) maxHossz = hossz;
                    hossz = 0;
                } else {
                    hossz++;
                }
            }
            if(hossz > maxHossz) maxHossz = hossz;

            System.Console.WriteLine(maxHossz);


        }
    }
    
}
