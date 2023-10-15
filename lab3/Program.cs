HRSystem system = new HRSystem();
system.createEmployee("Ion", 21, true, 10);
system.createEmployee("Vanea", 25, true, 15);
system.printInfo();



// A MESS!
// MeanCalculator meanCalc = new();
// MaxCalculator maxCalc = new();
// Console.WriteLine($"Mean cost per hour: {meanCalc.getMeanCostPerHour(system.employees)}");
// Console.WriteLine($"Mean age: {meanCalc.getMeanAge(system.employees)}");
// Console.WriteLine($"Max cost per hour: {maxCalc.getMaxCostPerHour(system.employees)}");
// Console.WriteLine($"Max age: {maxCalc.getMaxAge(system.employees)}");

// Use Facade instead:
StatisticsFacade statistics = new();
statistics.printStatistics(system.employees);


// Or use Proxy instead
StatisticsProxy statisticsX = new(statistics);
statisticsX.printStatistics(system.employees);

TimingDecorator timing = new(statisticsX);
timing.elapse(system.employees);