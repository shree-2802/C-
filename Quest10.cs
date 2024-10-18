public class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Workhard to get a better life love!");
    }
}

public class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Managing the team");
    }
}

Manager manager = new Manager();
manager.Work();