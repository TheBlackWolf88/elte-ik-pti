using System;
namespace Lesson6 {
    class Program {
        struct Worker{
            public int age;
            public int wage;
        }
        static void Main(String[] args){
           int n;
           int.TryParse(Console.ReadLine()!, out n);
           Worker[] d = new Worker[n];

           for(int i = 0; i < n; i++){
                string[] line = Console.ReadLine()!.Split(" ");
                int.TryParse(line[0], out d[i].age);
                int.TryParse(line[1], out d[i].wage);
           }

           int oW = 0;
           int cOldPoor = 0;
           int cAges = 0;
           int cYp = 0;

           for(int i = 0; i < n; i++){
                if(d[i].age > d[oW].age){
                    oW = i;
                }
           }
           Console.WriteLine(oW+1);

           for(int i = 0; i < n; i++){
                if(d[i].age > 40 && d[i].wage < 200000){
                    cOldPoor++;
                }
           }
           Console.WriteLine(cOldPoor);
           for(int i = 0; i < n; i++){
               int j = 0; 
               for (; j < i && d[i].age != d[j].age ; j++){}
               if (i == j) cAges++;
           }
           Console.WriteLine(cAges);

           for(int i = 0; i < n; i++){
               if(d[i].age < 30){
                   cYp++;
               }
           }

           int[] yPs = new int[cYp];
           int k = 0;
           for(int i = 0; i < n; i++){
                if(d[i].age < 30){
                    yPs[k] = i+1;
                    k++;
                }
           }

           Console.WriteLine(cYp + " " + String.Join(" ", yPs));
        }
    }
}
