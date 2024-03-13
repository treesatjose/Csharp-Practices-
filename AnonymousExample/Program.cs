using System.Security.Cryptography;

 class Program
{
    private static void Main(string[] args)
    {
        IList<Student> studentList= new List<Student>(){
            new Student() { StudentID =1, StudentName ="John",  Age = 21 },
            new Student() { StudentID = 2, StudentName ="Steve", Age = 20},
            new Student(){ StudentID = 3, StudentName ="Bill", Age = 30
            }
        };
        var students = from s in studentList select new { Id = s.StudentID, Name = s.StudentName, Age = s.Age};
        foreach(var stud in students)
        Console.WriteLine(stud.Id + "-" + stud.Name + "-" + stud.Age);
        }
    }

public class Student{
    public int StudentID{get; set;}
    public string StudentName{get; set;}
    public int Age { get; set;}
}