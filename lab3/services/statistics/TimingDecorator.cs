using System.Diagnostics;

public class TimingDecorator
{
    EmployeeStatistics statistics;
    Stopwatch watch = new();

    public TimingDecorator(EmployeeStatistics service)
    {
        statistics = service;
    }

    public void elapse(List<Employee> l)
    {
        watch.Start();
        statistics.printStatistics(l);
        watch.Stop();
        long time = watch.ElapsedMilliseconds;
        long ticks = watch.ElapsedTicks;
        
        Console.WriteLine($"Statistics executed in {time} ms ({ticks} ticks).");
        Console.WriteLine("----------------------------------");
    }
}