// // Object Pooling
// ObjectPool<Network> NeteworkPool = new ObjectPool<Network>();

// Network net1 = NeteworkPool.getObj();
// net1.initializeNetwork("N1", "StarLink");
// net1.connect();

// Network net2 = NeteworkPool.getObj();
// net2.initializeNetwork("N2", "StarLink");
// net2.connect();

// Network net3 = NeteworkPool.getObj();
// net3.initializeNetwork("N3", "StarLink");
// net3.connect();

// Console.WriteLine(NeteworkPool.getCounter());
// NeteworkPool.releaseObj(net2);
// NeteworkPool.releaseObj(net3);
// Console.WriteLine(NeteworkPool.getCounter());



// Prototype
// WeatherPresenter presenter1 = new WeatherPresenter("Jack", 36, true);
// SportPresenter presenter2 = new SportPresenter("Johanna", 26, false);
// Emission morning = new Emission();

// morning.addPresenter(presenter1);
// morning.addPresenter(presenter2);
// morning.addPresenter(presenter2.clone());
// morning.emitLive();



// Singleton
// GlobalStatistics data = GlobalStatistics.getInstance();

// Console.WriteLine(data.getTemperature());
// List<string> teams = data.getTeams();
// Console.WriteLine(teams[0] + " : " + teams[1]);
// Console.WriteLine(data.didWin());


// Factory method
PresenterCreator creator = new();
WeatherPresenter wp = (WeatherPresenter)creator.createPresenter("Vasika", 23, true, PresenterTypes.Weather);
SportPresenter sp = (SportPresenter)creator.createPresenter("Vasika", 23, true, PresenterTypes.Sport);

Emission morning = new Emission();
morning.addPresenter(wp);
morning.addPresenter(sp);
morning.emitLive();