//Sealed
public sealed class SmartPhone
{
    public void Call()
    {
        Console.WriteLine("This is call method in smartphone");
    }
}

class Samsung : SmartPhone
{
    public Samsung()
    {
        Console.WriteLine(" Obj created");
    }
}

Samsung samsung = new Samsung();