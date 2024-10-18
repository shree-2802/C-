public interface Iflyable
{
    void Flying()
    {
        Console.WriteLine("Flying in the interface");
    }
}
public class Birds : Iflyable
{
    public void Flying()
    {
        Console.WriteLine("Flying in the Birds");
    }
}


Birds birdObj = new Birds();
Console.WriteLine("Hello love");
birdObj.Flying();
