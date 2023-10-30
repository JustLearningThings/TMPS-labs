public class ProductSelection: VendingMachineState {
    public override string name { get; init; } = "Product Selection";

    public ProductSelection(VendingMachine context) : base(context) {}

    public override void operate()
    {
        Console.WriteLine("Choose from the list below:");
        printItems();
        Console.Write("\nYour choice: ");
        
        int choice = 0;
        choice = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your choice is {items[choice]} ({choice})");

        context.changeState(new Payment(context, items[choice]));
    }

    private void printItems()
    {
        for (int i = 0; i < items.Length; i++)
            Console.WriteLine($"{i}: {items[i]}");
    }
}