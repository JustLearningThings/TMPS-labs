public class Dispensing: VendingMachineState
{
    public override string name { get; init; } = "Dispensing";
    private string? item = "";

    public Dispensing(VendingMachine context, string? choosenItem) : base(context)
    {
        item = choosenItem;
    }

    public override void operate()
    {
        Console.WriteLine($"Dispensing {item}. Wait please...");
        Console.WriteLine($"Done! You can take your {item}.");

        context.changeState(new Idle(context));
    }
}