public class Emission
{
    private List<Presenter> presenters = new List<Presenter>();

    public void addPresenter(Presenter p) { presenters.Add(p); }
    public void emitLive()
    {
        foreach (Presenter p in presenters)
            if (p is WeatherPresenter wp)
                wp.present();
            else if (p is SportPresenter sp)
                sp.present();
    }
}