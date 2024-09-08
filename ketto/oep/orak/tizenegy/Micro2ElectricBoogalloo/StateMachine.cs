namespace Micro2ElectricBoogalloo;

public abstract class StateMachine
{
    private readonly Thread thread;
    private readonly MyQueue<Signal> eventQueue;
    private readonly Signal finalSignal;

    protected StateMachine(Signal none, Signal final)
    {
        this.finalSignal = final;
        eventQueue = new MyQueue<Signal>(none);
        thread = new(new ThreadStart(StateMachineProcess));
    }

    public void Send(Signal sig)
    {
        eventQueue.Enqueue(sig);
    }

    private bool inProcess;

    private void StateMachineProcess()
    {
        inProcess = true;
        while (inProcess)
        {
            try
            {
                Signal sig = eventQueue.Dequeue();
                if (sig.Equals(finalSignal)) inProcess = false;
                else Transition(sig);
            }
            catch (Exception)
            {

            }

        }
    }

    protected abstract void Transition(Signal sig);
}

