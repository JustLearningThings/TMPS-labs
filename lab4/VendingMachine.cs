public interface IVendingMachine {
    public void changeState(VendingMachineState state);
    public void showState();
    public void operate();
}

// context
public class VendingMachine: IVendingMachine {
    private VendingMachineState state;
    private List<Stakeholder> subscribers = new();
    public string? location = "Chisinau";

    public VendingMachine(string? location = null)
    {
        state = new Idle(this);
        this.location = location;
    }

    public void changeState(VendingMachineState newState) { state = newState; }

    public void showState() { state.showState(); }

    public void operate()
    {
        Console.WriteLine();
        state.showState();
        Console.WriteLine();
        state.operate();
    }

    // ============================================================================
    public void addSubscriber(Stakeholder s)
    {
        subscribers.Add(s);
    }

    public void removeSubscribers(Stakeholder s)
    {
        subscribers.Remove(s);
    }

    public void notifySubscribers(string item, int amount)
    {
        foreach(var s in subscribers)
            s.update(item, amount);
    }
}