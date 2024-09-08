using TextFile;
namespace Bead5
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1) throw new ArgumentException();

            TextFileReader reader = new TextFileReader(args[0]);

            double s = 0;
            int db = 0;

            bool st = reader.ReadDouble(out double e);
            while (st && e > 0)
            {
                s += e;
                db++;
                st = reader.ReadDouble(out e);
            }
            double a = s / db;

            bool l = true;
            double kicsi = e;
            st = reader.ReadDouble(out e);
            while (st)
            {
                l = l && e < 0;
                if (e < kicsi) kicsi = e;
                st = reader.ReadDouble(out e);
            }

            System.Console.WriteLine(a);
            System.Console.WriteLine(l);
            System.Console.WriteLine(kicsi);
        }

    }
}
