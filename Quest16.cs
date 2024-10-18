public class Factory
{
    public virtual void Preparation()
    {
        Console.WriteLine("Preparation on going.");
    }
}

public class Chocolate : Factory
{
    public string[] Products { get; set; }
    public int[] Amount { get; set; }

    //overriding
    public override void Preparation()
    {
        Console.WriteLine("Chocolate is being prepared.");
    }

    //overloading
    public void Addition(string[] products)
    {
        this.Products = products;
        Console.WriteLine(string.Join(", ", products));
    }

    public void Addition(int[] amount)
    {
        this.Amount = amount;
        Console.WriteLine(string.Join(", ", amount));
    }

}

public class Biscuit : Factory
{
}

Chocolate chocolate = new Chocolate();
chocolate.Addition(["Sugar", "Fresh Cream", "Cocoa Powder"]);
chocolate.Addition([1, 2, 5, 8]);
Console.WriteLine($"Products {string.Join(", ", chocolate.Products)} and amount {string.Join(", ", chocolate.Amount)}");
Biscuit biscuit = new Biscuit();
biscuit.Preparation();

