using System;
namespace Lesson6 {
    class Program {
        struct Ingatlan{
            public int t;
            public int p;
        }
        static void Main(String[] args){
           int N;
           int.TryParse(Console.ReadLine()!, out N);
           Ingatlan[] a = new Ingatlan[N];

           for(int i = 0; i < N; i++){
                string[] line = Console.ReadLine()!.Split(" ");
                int.TryParse(line[0], out a[i].t);
                int.TryParse(line[1], out a[i].p);
           }

           int draga = 0;
           int ct100p40 = 0;
           int cTeruletek = 0;
           int cVeryDraga = 0;

           for(int i = 0; i < N; i++){
                if(a[i].p > a[draga].p){
                    draga = i;
                }
           }
           Console.WriteLine(draga+1);

           for(int i = 0; i < N; i++){
                if(a[i].t > 100 && a[i].p < 40){
                    ct100p40++;
                }
           }
           Console.WriteLine(ct100p40);
           for(int i = 0; i < N; i++){
               int j = 0; 
               for (; j < i && a[i].t != a[j].t ; j++){}
               if (i == j) cTeruletek++;
           }
           Console.WriteLine(cTeruletek);

           for(int i = 0; i < N; i++){
               if(a[i].p > 100){
                   cVeryDraga++;
               }
           }

           int[] veryDragak = new int[cVeryDraga];
           int k = 0;
           for(int i = 0; i < N; i++){
                if(a[i].p > 100){
                    veryDragak[k] = i+1;
                    k++;
                }
           }

           Console.WriteLine(cVeryDraga + " " + String.Join(" ", veryDragak));
        }
    }
}
