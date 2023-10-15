public class MeanCalculator {
    public int getMeanCostPerHour(List<Employee> l) {
        int s = 0;

        foreach (var e in l)
            s += e.costPerHour;
        
        return s / l.Count;
    }

    public int getMeanAge(List<Employee> l) {
        int s = 0;

        foreach (var e in l)
            s += e.age;
        
        return s / l.Count;
    }
}