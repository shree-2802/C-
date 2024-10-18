public class Vehicle{
    public void StartEngine(){
        Console.WriteLine("Start engine love!");
    }
}

public class Car:Vehicle{
    public void Drive(){
        Console.WriteLine("Drive the car love!");
    }
}

Car car=new Car();
car.StartEngine();
car.Drive();