using System;
using Data.Generic.List;
namespace Lesson9
{
    class Program {
        public static void Main(string[] args){
            
            int N;
            int M;
            int K;
            string[] line = Console.ReadLine()!.Split(" ");
            int.TryParse(line[0], out N);
            int.TryParse(line[1], out M);
            int.TryParse(line[2], out K);
            
            int[] dbFajtaGy = new int[M];
            int[] dbGyartoF = new int[K];
            int[] maxArGy = new int[M];

            int minGy = 0;
            int minF = 0;
            int minAr = 10000;

            for(int i = 0; i < N; i++){
                //ujrahasznalhato mert ugyanannyi mezo
                line = Console.ReadLine()!.Split(" ");
                int gy = int.Parse(line[0]);
                int f = int.Parse(line[1]);
                int ar = int.Parse(line[2]);
                if (ar < minAr) {
                    minAr = ar;
                    minGy = gy;
                    minF = f;
                }
                dbFajtaGy[gy-1]++;
                dbGyartoF[f-1]++;
                if (maxArGy[gy-1] < ar) maxArGy[gy-1] = ar;
            }

            System.Console.WriteLine(minGy + " " + minF);

            int maxGy = 0;
            int maxdb = dbFajtaGy[1];
            for(int i=0; i < M; i++){
               // System.Console.WriteLine(i + " " + dbFajtaGy[i]);
                if(dbFajtaGy[i] > maxdb){
                    maxdb = dbFajtaGy[i];
                    maxGy = i+1;
                }
            }
            System.Console.WriteLine(maxGy);

            int dbMaxAr = 0;
            for(int i = 0; i < M; i++){
                if(maxArGy[i] != 0) dbMaxAr++;
            }
            Console.Write(dbMaxAr);
            for(int i = 0; i < M; i++){
                if(maxArGy[i] != 0){
                    Console.Write(" " + (i+1) + " " + maxArGy[i]);
                }
            }
            Console.WriteLine();

            int dbFajta = 0;
            for(int i = 0; i < K; i++) {
                if(dbGyartoF[i] != 0){
                    dbFajta++;
                }
            }
            System.Console.WriteLine(dbFajta);
            
            int dbEgy = 0;
            List<int> egy = new List<int>();
            for(int i = 0; i < K; i++){
                if(dbGyartoF[i] == 1){
                    egy.Add(i+1);
                    dbEgy++;
                }
            }
            Console.WriteLine(dbEgy + " " + String.Join(" ", egy));


        }
    }
    
}
