public class Country : AdministrativeEntity {
    public string? capital;

    public Country(string name, int population, int size, string capital) : base(name, population, size) {
        this.capital = capital;
    }
}