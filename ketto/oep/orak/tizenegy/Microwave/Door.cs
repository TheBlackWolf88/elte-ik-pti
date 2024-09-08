

namespace Microwave;

public class Door
{
    public bool Closed { get; private set; }
    private Magnetron magn;
    private Lamp lamp;

    public Door()
    {
        Closed = true;
    }

    public void Control(Magnetron magn, Lamp lamp)
    {
        this.magn = magn;
        this.lamp = lamp;
    }

    internal void Open()
    {
        throw new NotImplementedException();
    }

    internal void Close()
    {
        throw new NotImplementedException();
    }
}

