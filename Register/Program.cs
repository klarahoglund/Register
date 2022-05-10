

List<worker> register = new List<worker>();


Console.WriteLine("Välkommen till Registret");


Console.WriteLine("Vill du lägga till en anställd, tryck a.Vill du skriva ut, tryck s");
string valet = Console.ReadLine();

if (valet== "a")
{
    addWorker();
   
    
}
else if (valet== "s")
{
    skrivUt();
}

void skrivUt()
{
    foreach (worker worker in register)
    {
        Console.WriteLine(worker);  
    }
}

void addWorker()
{
    Console.WriteLine("Lön: ");

    string hold = Console.ReadLine();

    int salary = Convert.ToInt32(hold);
    Console.WriteLine("Namn: ");

    string name = Console.ReadLine();

    if (name.Length > 0)
    {
        worker worker = new(name, salary);
        register.Add(worker);
    }

}