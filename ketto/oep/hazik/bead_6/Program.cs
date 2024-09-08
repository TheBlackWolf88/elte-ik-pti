using TextFile;
namespace Bead6
{
    class Program
    {
        public static void Main(string[] args){
            if (args.Length != 1) throw new ArgumentException();
            TextFileReader reader = new TextFileReader(args[0]);
            int bevet = 0;
            bool st = reader.ReadLine(out string sor);
            while (st) {
                string[] sorDarabolt = sor.Split(" ");
                for (int i = 2; i < sorDarabolt.Length; i += 2){
                    bevet += int.Parse(sorDarabolt[i]);
                }
                st = reader.ReadLine(out sor);
            }
            System.Console.WriteLine(bevet);


        }
        
    }
    
}
