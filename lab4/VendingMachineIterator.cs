public interface IVendingMachineIterator
{
    public VendingMachine? getNext(string location);
    public bool hasMore();
}

public class VendingMachineIterator: IVendingMachineIterator
{
    private VendingMachine[] collection;
    private int iterationState = 0;

    public VendingMachineIterator(VendingMachine[] vms)
    {
        collection = vms;
    }

    public VendingMachine? getNext(string location)
    {
        iterationState++;

        while (hasMore() && collection[iterationState - 1].location != location)
            iterationState++;

        if (!hasMore())
            return null;

        return collection[iterationState - 1];
    }

    public bool hasMore() => iterationState < collection.Count();

    public void reset() { iterationState = 0; }

    public void iterateAllAndPrint(string location)
    {
        while(hasMore()) {
            VendingMachine? m = getNext(location);

            if(m == null)
                break;

            Console.WriteLine(m.location);
        }

        reset();
    }
}