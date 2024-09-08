namespace HydroCircle
{
    public class BadFileFormatException : Exception;
    class Program
    {
        public static void Main(string[] args)
        {
            Atmosphere? atmo = null;
            try
            {
                String line;
                StreamReader sr = new StreamReader(args[0]);
                line = sr.ReadLine()!;
                String[] lineSplit = new String[3];
                if (line != null) lineSplit = line.Split(" ");
                atmo = new Atmosphere(int.Parse(lineSplit[0]));
                line = sr.ReadLine()!;
                while (line != null)
                {
                    lineSplit = line.Split(" ");
                    Area area = new Area(atmo, lineSplit[0], int.Parse(lineSplit[2]), null);

                    switch (lineSplit[1][0])
                    {
                        case 'p': area.ChangeType(new Plains(area)); break;
                        case 'z': area.ChangeType(new Green(area)); break;
                        case 't': area.ChangeType(new Swamp(area)); break;
                    }
                    atmo.AddArea(area);
                    line = sr.ReadLine()!;
                }
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("The file wasn't found.");
                return;
            }
            catch (NullReferenceException)
            {
                System.Console.Error.WriteLine("Nullref");
            }
            if (atmo == null)
            {
                throw new BadFileFormatException();
            }
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("===============================");
                System.Console.WriteLine("Round " + (i + 1));
                System.Console.WriteLine("===============================\n");
                atmo.VisitAreas(atmo.Weather());

            }
            bool b = atmo.MaxWaterVolume(out int max, out Area? a);
            System.Console.WriteLine("===============================");
            System.Console.WriteLine("Area with largest water volume: ");
            System.Console.WriteLine("===============================\n");
            if (b)
            {
                System.Console.WriteLine(a);
            }
            else
            {
                System.Console.WriteLine("No such area");
            }
        }
    }

}

