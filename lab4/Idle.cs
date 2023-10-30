public class Idle: VendingMachineState
{
    public override string name { get; init; } = "Idle";
    public Idle(VendingMachine context) : base(context) {}

    public override void operate()
    {
        Console.Clear();
        Console.WriteLine("Press 's' to continue...");
        
        string input = Console.ReadLine();

        if (input == "s")
            context.changeState(new ProductSelection(context));
        
        Console.Clear();
    }
}