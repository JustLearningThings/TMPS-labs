public sealed class GlobalStatistics {
    public static GlobalStatistics? _instance;
    private Random rand = new Random();
    private List<string> teams = new List<string> {"Real Madrid", "Real Sociedad", "PSG", "Barcelona", "Borussia Dortmund", "Bayern Munchen"};

    private GlobalStatistics() {}

    public static GlobalStatistics getInstance()
    {
        if (_instance == null)
            _instance = new GlobalStatistics();
    
        return _instance;
    }

    public int getTemperature() => rand.Next(-30, 50);
    
    public List<string> getTeams()
    {
        List<string> retTeams = new();
        int id = rand.Next(0, teams.Count - 1),
            id2 = rand.Next(0, teams.Count - 1);

        retTeams.Add(teams[id]);

        while (id2 == id)
            id2 = rand.Next(0, teams.Count - 1);
        
        retTeams.Add(teams[id2]);

        return retTeams;
    }

    public bool didWin() => rand.Next(0, 1) == 1;
}