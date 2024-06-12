using System;
namespace third_project{

    using System;

struct Student
{
    public int SrNo;
    public string Name;
    public string Branch;
    public string Stream;
    public string College;

    // Constructor to initialize the struct
    public Student(int srNo, string name, string branch, string stream, string college)
    {
        SrNo = srNo;
        Name = name;
        Branch = branch;
        Stream = stream;
        College = college;
    }

    // Method to display student information
    public void Display()
    {
        Console.WriteLine($"SrNo: {SrNo}, Name: {Name}, Branch: {Branch}, Stream: {Stream}, College: {College}");
    }
}

    internal class Program{
        public static void Main(string[] args){
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Create an array of Student structs
        Student[] students = new Student[numStudents];

        // Loop to take user input for each student
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Enter details for student {i + 1}:");

            Console.Write("SrNo: ");
            int srNo = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Branch: ");
            string branch = Console.ReadLine();

            Console.Write("Stream: ");
            string stream = Console.ReadLine();

            Console.Write("College: ");
            string college = Console.ReadLine();

            students[i] = new Student(srNo, name, branch, stream, college);
        }

        // Display the students
        Console.WriteLine("You have entered the following student details:");
        foreach (Student student in students)
        {
            student.Display();
        }
        }
    }
}
