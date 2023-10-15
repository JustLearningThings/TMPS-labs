public class MaxCalculator {
    public int getMaxCostPerHour(List<Employee> l) {
        int s = 0;

        foreach (var e in l)
            if (e.costPerHour > s)
                s = e.costPerHour;
        
        return s;
    }

    public int getMaxAge(List<Employee> l) {
        int s = 0;

        foreach (var e in l)
            if (e.costPerHour > s)
                s = e.age;
        
        return s;
    }
}