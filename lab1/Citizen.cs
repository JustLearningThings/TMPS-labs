public class Citizen : IPrivatePerson {
    public string name;
    public int age;

    public Citizen(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"'Hello! My name is {name}. I am {age}.'\n");
    }
}