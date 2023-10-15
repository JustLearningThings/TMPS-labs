// Client
public class HRSystem {
    private int id = 0;
    public int num_employees = 0;
    public List<Employee> employees = new List<Employee>();

    public HRSystem() {}

    public createEmployee(
        string name,
        int age,
        bool gender,
        int cph
    )
    {
        employees.Add(new Emoployee(
            name, age, gender, cph, id
        ));

        id++;
    }
}