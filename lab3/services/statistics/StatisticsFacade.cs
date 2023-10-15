public interface EmployeeStatistics {
    public void printStatistics(List<Employee> l);
}

public class StatisticsFacade: EmployeeStatistics {
    public MeanCalculator meanCalc = new();
    public MaxCalculator maxCalc = new();

    public void printStatistics(List<Employee> l)
    {
        Console.WriteLine($"Mean cost per hour: {meanCalc.getMeanCostPerHour(l)}");
        Console.WriteLine($"Mean age: {meanCalc.getMeanAge(l)}");
        Console.WriteLine($"Max cost per hour: {maxCalc.getMaxCostPerHour(l)}");
        Console.WriteLine($"Max age: {maxCalc.getMaxAge(l)}");
    }
}