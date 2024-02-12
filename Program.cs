using System.Net;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }

    // //parameterized Constructor
    // public Student(int id, string name, string subject) 
    // {
    //     Id = id;
    //     Name = name;
    //     Subject = subject;
    // }
    // //default constructor
    // public Student() {}

    //void === no return
    public void PrintInfo()
    {
        Console.WriteLine("For Id :: " + Id);
        Console.WriteLine("Name :: " + Name);
        Console.WriteLine("Subject :: " + Subject);
    }
}

public class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your student Id :: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your Name:: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter Your subject:: ");
        string subject = Console.ReadLine();

        Student student = new Student();
        student.Id = id;
        student.Name = name;
        student.Subject = subject;

        student.PrintInfo();
    }
}