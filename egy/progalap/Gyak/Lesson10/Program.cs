using System;
namespace Beadando1
{
    class Program
    {
        static void Main(string[] args)
        {
            int orsegek;
            int.TryParse(Console.ReadLine()!, out orsegek);
            int[] falak = new int[orsegek-2];
            for (int i = 0; i < orsegek; i++)
            {
                int be = int.Parse(Console.ReadLine()!);
                if(be != 0){
                    falak[i]++;
                    if(i != 0) falak[i-1]++;
                }
                
            }
            Console.Error.WriteLine(String.Join(" ", falak));

            int orzott = 0;
            for (int i = 0; i < orsegek; i++){
                
            }
            System.Console.WriteLine(orzott);
        }
    }
}
