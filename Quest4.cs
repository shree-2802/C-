public class Student
{
    private int grade;
    public int Grade
    {
        get { return grade; }
        set { if (value >= 0 && value <= 100) this.grade = value; else throw new ArgumentException("Value does not fall under 0 to 100");}
    }
}

Student student = new Student();
Console.WriteLine(student.Grade);
student.Grade = 100;
Console.WriteLine(student.Grade);
student.Grade = 150;