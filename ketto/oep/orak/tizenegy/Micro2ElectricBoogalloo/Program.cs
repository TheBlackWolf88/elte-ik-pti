namespace Micro2ElectricBoogalloo;

public enum Signal { started, stopped, pressed, opened, closed, none, final }

public class Magnetron: StateMachine {

    private Door door;
    private Lamp lamp;

    public Magnetron() : base(Signal.none, Signal.final)
    {
    }
}

public class Microwave { }
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
