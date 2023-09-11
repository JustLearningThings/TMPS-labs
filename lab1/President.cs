public class President : IPublicPerson {
    public string name;
    public int startYear;
    public int endYear;

    public President(string name, int sy, int ey)
    {
        this.name = name;
        this.startYear = sy;
        this.endYear = ey;
    }

    public void Sign(string signedWith)
    {
        Console.WriteLine($"{name} ({startYear} - {endYear}) signed a contract with {signedWith}.\n");
    }
}