public interface IStakeholderSubscriber
{
    public void update(string item, int amount);
}

public class Stakeholder
{
    public void update(string item, int amount)
    {
        Console.WriteLine("\n\n=============Stakeholder===============");
        Console.WriteLine($"Somebody bought {item} for ${amount}.");
        Console.WriteLine("=======================================\n\n");
    }
}