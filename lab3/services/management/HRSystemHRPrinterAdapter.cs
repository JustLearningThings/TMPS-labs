public class HRSystemHRPrinterAdapter {
    private HRPrinter printer = new HRPrinter();
    
    public void printInfo(List<Employee> employees)
    {
        printer.printList(_employeeCharToList(employees), employees.Count);
        printer.printLen(_employeeCharToList(employees), employees.Count);
    }

    private Employee[] _employeeCharToList(List<Employee> l) {
        Employee[] employees = new Employee[l.Count];

        for (int i = 0; i < l.Count; i++)
            employees[i] = l[i];
        
        return employees;
    }
}