class Variables{
    private int x;
    public int Y{get;set;}=20;//Compile time initialization
    public int X{
        get{return x;}
        set{x=value;}
    }
}

Variables variables=new Variables();
variables.X=Convert.ToInt32(Console.ReadLine());//run time initialization
Console.WriteLine(variables.X);