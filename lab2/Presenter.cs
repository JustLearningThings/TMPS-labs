public abstract class Presenter
{
    public string name;
    public int age; 
    protected bool gender;

    public Presenter(string personName, int personAge, bool personGender)
    {
        name = personName;
        age = personAge;
        gender = personGender;
    }

    public abstract Presenter clone();
    public abstract void present();
    public string getGender() => gender ? "male" : "female";
}