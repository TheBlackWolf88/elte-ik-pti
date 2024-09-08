namespace Microwave;

public class Button
{
    private Magnetron magn;

    public void Control(Magnetron magn) {
        this.magn = magn;
    }

    public void Press(){
        magn.Send(Signal.pressed);
    }

}

