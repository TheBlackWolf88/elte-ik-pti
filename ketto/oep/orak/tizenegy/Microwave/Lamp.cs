
namespace Microwave;

public class Lamp
{
    private bool lit;

    public Lamp()
    {
        lit = false;
    }

    public void Send(Signal sig)
    {
        switch (sig)
        {
            case Signal.opened: case Signal.started: lit = true; break;
            case Signal.closed: case Signal.stopped: lit = false; break;
            default: break;
        }
    }

    public override string? ToString()
    {
        return "Lamp is " + (lit ? "lit" : "off");
    }
}

