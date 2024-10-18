
interface ISwimmable
{
    void Swim();
}
interface IFlyable
{
    void Fly();
}
public class Penguin : IFlyable, ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("Penguins can swim.");
    }
}

Penguin penguin = new Penguin();
penguin.Fly();
penguin.Swim();