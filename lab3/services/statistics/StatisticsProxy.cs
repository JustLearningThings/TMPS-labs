public class StatisticsProxy : EmployeeStatistics { // same interface
    private EmployeeStatistics statistics; // pointer to original object

    public StatisticsProxy(EmployeeStatistics service)
    {
        statistics = service;
    }

    public void printStatistics(List<Employee> l)
    {
        Console.WriteLine("\n-----Statistics of HR System------");
        statistics.printStatistics(l);
        Console.WriteLine("----------------------------------");
    }
}