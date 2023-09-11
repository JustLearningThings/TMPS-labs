public class DataPrinter {
    public void Print(Country entity)
    {
        Console.WriteLine($"{entity.name} is a country with a population of {entity.population} and a size of {entity.size} sq. km.\nIts capital is {entity.capital}.\n");
    }

    public void Print(City entity)
    {
        Console.WriteLine($"{entity.name} is a city with a population of {entity.population} and a size of {entity.size} sq. km.\nIt's main symbol is {entity.symbol}.\n");
    }

    public void Print(AdministrativeEntity entity)
    {
        Console.WriteLine($"{entity.name} is an administrative entity with a population of {entity.population} and a size of {entity.size} sq. km.\n");
    }
}