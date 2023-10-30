public class Payment: VendingMachineState
{
    public override string name { get; init; } = "Payment";
    private string? item = "";

    public Payment(VendingMachine context, string? choosenItem) : base(context)
    {
        item = choosenItem;
    }

    public override void operate()
    {
        Console.Write("This is donation-based, you decide how much to pay...\n\n\t$");
        
        string amount = Console.ReadLine();
        Console.WriteLine($"\nPayment of ${amount} received!");

        context.notifySubscribers(item, int.Parse(amount));
        context.changeState(new Dispensing(context, item));
    }
}