public class Car
{
    private int speed;
    public int Speed
    {
        get { return speed; }
        set { if (value >= 0 && value <= 200) this.speed = value; else throw new ArgumentException("speed can only be set in range of 0 to 200 love!"); }
    }
    public void getSpeed(){
        Console.WriteLine(speed);
    }
}

Car car=new Car();
car.Speed=200;
car.getSpeed();
car.Speed=0;
car.getSpeed();
car.Speed=-1;