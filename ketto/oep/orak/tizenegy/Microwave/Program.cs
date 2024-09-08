namespace Microwave;

class Program
{
    static void Main(string[] args)
    {
        Microwave micro = new Microwave();
        micro.door.Open(); System.Console.WriteLine(micro);
        micro.door.Close(); System.Console.WriteLine(micro);
        micro.button.Press(); System.Console.WriteLine(micro);

    }
}
