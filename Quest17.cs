interface Iplayable
{
    void play();
}

interface IWritable
{
    void write();
}
public class Guitar : Iplayable, IWritable
{
    public void play()
    {
        Console.WriteLine("Play your guitar");
    }
    public void write()
    {
        Console.WriteLine("Guiter can't write.")
    }
}

public class Piano : Iplayable
{
    public void play()
    {
        Console.WriteLine("Play your piano.");
    }
}

Guitar guitar = new Guitar();
Piano piano = new Piano();
guitar.play();
piano.play();