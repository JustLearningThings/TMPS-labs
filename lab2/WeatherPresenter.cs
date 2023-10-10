public class WeatherPresenter: Presenter
{
    public WeatherPresenter(string personName, int personAge, bool personGender) : base(personName, personAge, personGender) {}

    public override void present()
    {
        Console.WriteLine($"(Weather) Hello, my name is {name}. The temperature is {GlobalStatistics.getInstance().getTemperature()}.");
    }

    public override Presenter clone() => new WeatherPresenter(this.name, this.age, this.gender);
}