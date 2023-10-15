// printer service expects Employee[], while given is List<Employee>
public interface Printer {
    public void printList(Employee[] l, int n);
    public void printLen(Employee[] l, int n);
}

public class HRPrinter: Printer {
    public void printList(Employee[] l, int n)
    {
        for (int i = 0; i < n; i++) {
            string gender = l[i].gender ? "male" : "female";
            Console.WriteLine($"{l[i].id}: {l[i].name} ({gender}) has {l[i].age} years old and yearns ${l[i].costPerHour}/hour.");
        }
    }

    public void printLen(Employee[] l, int n)
    {
        Console.WriteLine($"There are {n} employees in the system.");
    }
}

