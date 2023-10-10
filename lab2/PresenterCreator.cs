public interface IPresenterCreator {

    Presenter createPresenter(string personName, int personAge, bool personGender, PresenterTypes type);
}

public class PresenterCreator : IPresenterCreator {
    public Presenter createPresenter(string personName, int personAge, bool personGender, PresenterTypes type) =>
        type == PresenterTypes.Weather ?
        new WeatherPresenter(personName, personAge, personGender) :
        new SportPresenter(personName, personAge, personGender);
}

public enum PresenterTypes {
    Weather = 0,
    Sport = 1
}