public class SportPresenter: Presenter
{
    public SportPresenter(string personName, int personAge, bool personGender) : base(personName, personAge, personGender) {}

    public override void present()
    {
        GlobalStatistics data = GlobalStatistics.getInstance();
        List<string> teams = data.getTeams();
        string status = data.didWin() ? "won" : "lost";
        
        Console.WriteLine($"(Sports) Hello, my name is {name}. {teams[0]} played with {teams[1]} and {status}.");
    }

    public override Presenter clone() => new SportPresenter(this.name, this.age, this.gender);
}