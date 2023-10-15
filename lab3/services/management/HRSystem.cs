public interface ManagementSystem {
    public void printInfo();
}

// Client
public class HRSystem: ManagementSystem {
    private int id = 0;
    public int num_employees = 0;
    public List<Employee> employees = new List<Employee>();
    // private HRPrinter printer = new HRPrinter(); // INCOMPATIBLE WITH SERVICE!
    private HRSystemHRPrinterAdapter printer = new();

    public HRSystem() {}

    public void createEmployee(
        string name,
        int age,
        bool gender,
        int cph
    )
    {
        employees.Add(new Employee(
            name, age, gender, cph, id
        ));

        id++;
    }

    public void printInfo() {
        printer.printInfo(employees);
    }
}