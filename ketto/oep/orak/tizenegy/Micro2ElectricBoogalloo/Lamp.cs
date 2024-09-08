namespace Micro2ElectricBoogalloo;

public class Lamp : StateMachine
{

    private bool lit;
    public Lamp(Signal none, Signal final) : base(none, final)
    {
        lit = false;
    }

    protected override void Transition(Signal sig)
    {
        switch (sig)
        {
            case Signal.opened: case Signal.started: lit = true; break;
            case Signal.closed: case Signal.stopped: lit = false; break;

            default: break;
        }
    }

    public override string ToString()
    {
        return "Lamp is " + (lit ? "lit" : "off");
    }
}

