using TextFile;

namespace counteven
{
    public class Program {
        public static void Main(string[] args){
            TextFileReader reader = new TextFileReader("input.txt");
            int evens = 0;
            bool negative = false;
            while (!negative && reader.ReadInt(out int num)){
                negative = num < 0;
                if (num % 2 == 0) evens ++;

            }
            System.Console.WriteLine("Evens before first neg: " + evens);
            evens = 0;
            while (reader.ReadInt(out int num)){

                if (num % 2 == 0) evens ++;
            }
            System.Console.WriteLine("Evens after: " + evens);
        }
    }
}
