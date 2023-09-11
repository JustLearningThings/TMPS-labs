Console.WriteLine("HI\n");

DataPrinter Printer = new DataPrinter();
Country Moldova = new Country("Moldova", 3435931, 33483, "Chisinau");
City Chisinau = new City("Chisinau", 635994, 123, "Triumphal Arch");
AdministrativeEntity AE = new City("Kyiv", 3017000, 839, "The Motherland Monument");

Printer.Print(Moldova);
Printer.Print(Chisinau);
Printer.Print(AE);

Chisinau.Celebrate("Wine Day");

Citizen Mark = new Citizen("Mark", 32);
Mark.Introduce();

President Maia = new President("Maia Sandu" , 2020, 2024);
Maia.Sign("Andrzej Duda");