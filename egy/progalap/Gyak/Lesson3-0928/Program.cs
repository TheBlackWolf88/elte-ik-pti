using System;

namespace Lesson3 {
    class Program {
        public static void  Main(string[] args){


            int N;
            Console.Error.Write("How many dolgozo: ");
            int.TryParse(Console.ReadLine(), out N);
           
            string[] sz = new string[N];
            for(int i = 0; i < N; i++){
                Console.Error.Write((i+1) + ". dolgozo szem szama: ");
                sz[i] = Console.ReadLine();
            }

            bool vanFerfi = false;
            foreach(string el in sz){
                if (el.StartsWith("1") || el.StartsWith("3")) {
                    vanFerfi = true;
                }
            } 
            Console.WriteLine("\nvanFerfi=" + vanFerfi);
            
            int fiatalLany=0;
            for(;fiatalLany < sz.Length; fiatalLany++){
                if(sz[fiatalLany].StartsWith("4")){
                    break;
                }
            }
            Console.WriteLine("fialtalLany=" + (fiatalLany+1));

            bool vanKiskoru=false;
            //05 09 29
            int kiskoru = -1;
            for(int i = 0; i < sz.Length; i++){
                if( (sz[i].StartsWith("3") || sz[i].StartsWith("4")) && int.Parse(sz[i].Substring(2, 6)) >= 50929){
                    vanKiskoru = true;
                    kiskoru = i;
                }
            }

            Console.WriteLine("vanKiskoru=" + vanKiskoru);
            if (kiskoru != -1) {
                Console.WriteLine("kiskoru=" + (kiskoru+1));
            } else {
                Console.Error.WriteLine("kiskoru=nincs");
            }  

            int legfiatalabb = 0;
            int legfiatalabbAge = 0;

            for(int i = 0; i < sz.Length; i++){
                if((sz[i].StartsWith("3") || sz[i].StartsWith("4")) && int.Parse(sz[i].Substring(2, 6)) > legfiatalabbAge){
                    legfiatalabb = i;
                    legfiatalabbAge = int.Parse(sz[i].Substring(2, 6));
                }
            }

            Console.WriteLine("legfiatalabb=" + (legfiatalabb+1));
            Console.Error.WriteLine("legfiatalabbAge=" + legfiatalabbAge);

        }

    }
}
