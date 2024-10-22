//Identifiers
interface SampleInterface{
    void DisplayNumber();
}

class Identifiers:SampleInterface
{
    private int number;

    public int Number //Write-only
    {
        set { this.number = value; }
    }
    public Identifiers()
    {
        Console.WriteLine("Identifier class initialized.");
    }

    public void DisplayNumber(){
        Console.WriteLine(this.number);
    }
}

Identifiers identifiers=new Identifiers();
identifiers.Number=20;
identifiers.DisplayNumber();

/*

        Name            type of identifier
    identifier      -   Instance or Object
    Identifiers     -   Class Name
    number          -   Variable holder or container
    Number          -   Property name
    displayNumber   -   Method name
    SampleInterface -  Interface name

*/