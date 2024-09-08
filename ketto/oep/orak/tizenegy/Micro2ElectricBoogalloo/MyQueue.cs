namespace Micro2ElectricBoogalloo;

public class MyQueue<Signal> {
    private readonly Signal noneSignal;

    public MyQueue(Signal noneSignal)
    {
        this.noneSignal = noneSignal;
    }

    private readonly Queue<Signal> queue = new();
    private readonly object criticalSection = new object();

    public bool IsEmpty(){
        return queue.Count == 0;
    }

    public void Enqueue(Signal signal) {
        Monitor.Enter(criticalSection);
        queue.Enqueue(signal);
        Monitor.Exit(criticalSection);
    }

    public Signal Dequeue () {
        Signal s;
        Monitor.Enter(criticalSection);
        if (!IsEmpty()) {
            s = queue.Dequeue();
        }
        else {
            s = noneSignal;
        }
        Monitor.Exit(criticalSection);
        return s;

    }
}

