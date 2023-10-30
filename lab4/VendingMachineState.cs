public interface IState {
    public void setContext(VendingMachine newContext);
    public void showState();
}

public abstract class VendingMachineState: IState {
    public abstract string name { get; init; }
    protected VendingMachine context { get; set; }
    protected string[] items { get; } = {
        "Soda",
        "Chips",
        "Water",
        "Candy",
        "Cookies"
    };

    public VendingMachineState(VendingMachine vm)
    {
        context = vm;
    }

    // just for demonstation; here not needed
    public void setContext(VendingMachine newContext) { context = newContext; }

    public void showState()
    {
        Console.WriteLine($"... {name} ...");
    }

    public abstract void operate();
}