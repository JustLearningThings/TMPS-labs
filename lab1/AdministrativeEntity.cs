public abstract class AdministrativeEntity {
    public string name;
    public int population;
    public int size;

    public AdministrativeEntity(string name, int population, int size)
    {
        this.name = name;
        this.population = population;
        this.size = size;
    }
}