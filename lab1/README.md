# Lab 1

SOLID is the composition of the five principles of object-oriented design and programming, which were first introduced by Robert C. Martin. The SOLID principles provide a set of guidelines for designing and building robust, maintainable, and scalable software systems.

---

## Single Responsibility Principle
SRP states that each class should do one thing, and have only one reason to change.

An example of SRP in this code is in the `DataPrinter` class:
```cs
public class DataPrinter {
    public void Print(Country entity) { ... }

    public void Print(City entity) { ... }
}
```
## Open-Closed Principle and Dependency Inversion Principle
OCP states that classes should be open to extension and closed for modification. 

It goes along with DIP, which states that classes should depend on interfaces (or abstract classes) insted of a concrete entity.

In the code, both the principles can be observed in the `City` or `Country` classes, that both inherit from `AdministrativeEntity`:
```cs
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
```

Let's look at `City`:
```cs
public class City : AdministrativeEntity {
    public string? symbol;

    public City(string name, int population, int size, string symbol) : base(name, population, size) {
        this.symbol = symbol;
    }

    // extension
    public void Celebrate(string what)
    {
        Console.WriteLine($"The city of {this.name} celebrates {what}. For that a festival will take place in the city center.\n");
    }
}
```

So `City` was extended, but not modified. It can call the method `Celebrate`:
```cs
City Chisinau = new City("Chisinau", 635994, 123, "Triumphal Arch");

Chisinau.Celebrate("Wine Day");
```
Output:
```
The city of Chisinau celebrates Wine Day. For that a festival will take place in the city center.
```


**"If the OCP states the goal of OO architecture, the DIP states the primary mechanism"**

*- Uncle Bob*

## Liskov Substitution Principle
LSP states that subclasses should be substitutable with their base classes.

An example in this code are the `Country`, `City` classes that inherit from `AdministrativeEntity`:
```cs
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

public class City : AdministrativeEntity {
    public string? symbol;

    public City(string name, int population, int size, string symbol) : base(name, population, size) {
        this.symbol = symbol;
    }

}

public class Country : AdministrativeEntity {
    public string? capital;

    public Country(string name, int population, int size, string capital) : base(name, population, size) {
        this.capital = capital;
    }

}
```
Here, `Country` and `City` inherit some properties of the base class. They do not modify these properties or behavior related to the base class. So, if you expect a base class and give a `City` or `Country`, it will work. And here is an example:
```cs
// Program.cs
AdministrativeEntity AE = new City("Kyiv", 3017000, 839, "The Motherland Monument");

Printer.Print(AE);

// DataPrinter.cs
public class DataPrinter {
    public void Print(Country entity) { ... }

    public void Print(City entity) { ... }

    public void Print(AdministrativeEntity entity)
    {
        Console.WriteLine($"{entity.name} is an administrative entity with a population of {entity.population} and a size of {entity.size} sq. km.\n");
    }
}
```
As you can see, when an `AdministrativeEntity` is expected, a subclass can be provided and everything works as expected, because the `City` in this example, doesn't modify any behaviour or properties of the base class.

And this is the output:
```
Kyiv is an administrative entity with a population of 3017000 and a size of 839 sq. km.
```

## Interface Segregation Principle
ISP states that client-specific interfaces are better than one general-purpose interface. Clients should not be forced to implement functionality they do not need.

Instead of having a general interface for a person, I separated the concept into a public and private person. A public person will be represendet, in this example, by a president. A private person - by a simple citizen.

The interfaces:
```cs
public interface IPublicPerson
{
    public void Sign(string signedWith);
}

public interface IPrivatePerson
{
    public void Introduce();
}
```

A public person may need to sign contracts in the name of an organization, while a simple citizen will be limited to just introduce himself.

```cs
public class Citizen : IPrivatePerson {
    public string name;
    public int age;

    public Citizen(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"'Hello! My name is {name}. I am {age}.'\n");
    }
}

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
```

So, the `Citizen` class didn't need to implement the `Sign` method, because it doesn't need it. Similarly for the `President` class. A president doesn't need to be introduced :).
