using TextFile;
namespace EvenNumbers
{
    public class Program {
        public static void Main (string[] args){
            string filename = Console.ReadLine();
            TextFileReader reader = new TextFileReader(filename);
            bool l = true;
            int max = 0;
            while (reader.ReadInt(out int num)){
                if (num > max) {
                    max = num;
                }
                if (l) {
                    l = (num % 2 == 0);
                }
            }

            System.Console.WriteLine("A legnagyobb szám: " + max);
            System.Console.WriteLine(l ? "Minden szám páros" : "Van páratlan szám");

        }
    }
    
}
