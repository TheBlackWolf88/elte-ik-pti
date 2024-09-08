namespace Microwave;

public enum Signal { started, stopped, pressed, opened, closed }

public class Microwave
{
    public readonly Button button = new();
    public readonly Door door = new();
    public readonly Lamp lamp = new();
    public readonly Magnetron magn = new();

    public Microwave()
    {
        button.Control(magn);
        door.Control(magn, lamp);
        magn.Control(lamp, door);
    }

    public override String ToString() {
        return String.Format($"(magn, -24) (door, -12) (lamp, -10) (door, -8)");
    }


}

