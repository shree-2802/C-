//Base
public class Animal
{
    protected string species;
    public Animal(string name)
    {
        Console.WriteLine("Animal class constructor is called.");
        this.species = name;
    }
}

public sealed class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Console.WriteLine("Dog class constructor is called.");
    }
    public void displayInfo()
    {
        Console.WriteLine(this.species);
    }
}

Dog dog = new Dog("Pomeranian");
dog.displayInfo();