public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal sound");
    }
}

sealed class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks bow bow.");
    }
}

sealed class Cat : Animal
{
    public Cat()
    {
        Console.WriteLine("Object for cat is created"ChatGPT said:
    }
}

Dog dog = new Dog();
Cat cat = new Cat();
dog.Speak();
