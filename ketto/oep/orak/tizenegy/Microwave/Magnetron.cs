namespace Microwave;

public class Magnetron
{
    private Door door;
    private Lamp lamp;
    private bool working;

    public Magnetron()
    {
        working = false;
    }

    public void Control (Lamp l, Door d) {
        lamp = l;
        door = d;
    }

    public void Send (Signal signal) {
        switch (signal)
        {
            case Signal.pressed:
                if (!working && door.Closed) {
                    lamp.Send(Signal.started);
                    working = true;
                }
                break;
            case Signal.opened:
                if (working) {
                    lamp.Send(Signal.stopped);
                    working = false;
                }
                break;
            
            default: break;
        }
    }
}

