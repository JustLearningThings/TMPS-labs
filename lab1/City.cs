public class City : AdministrativeEntity {
    public string? symbol;

    public City(string name, int population, int size, string symbol) : base(name, population, size) {
        this.symbol = symbol;
    }

    public void Celebrate(string what)
    {
        Console.WriteLine($"The city of {this.name} celebrates {what}. For that a festival will take place in the city center.\n");
    }
}