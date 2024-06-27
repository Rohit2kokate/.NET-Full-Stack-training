using System;
using System.Collections.Generic;
namespace MyNamespace
{
    class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Hello from MyNamespace.MyClass.MyMethod!");
        }
    }
}
namespace AnotherNamespace
{
    class AnotherClass
    {
        public void AnotherMethod()
        {
            Console.WriteLine("Hello from AnotherNamespace.AnotherClass.AnotherMethod!");
        }
    }
}
class Program
{

    static void Main()
    {
        List<string> names = new List<string> { "John", "Anna", "Zoe", "Mark", "Bob" };

        Console.WriteLine("Original list:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Sort();

        Console.WriteLine("\nSorted list:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        System.Console.WriteLine("----------------------------------------1-----------------------------");
        int number = 5;
        Console.WriteLine("Before method call, number: " + number);

        PassByValue(number);

        Console.WriteLine("After method call, number: " + number);
        System.Console.WriteLine("---------------------------------2-------------------------------------");
        int number = 5;
        Console.WriteLine("Before method call, number: " + number);

        PassByReference(ref number);

        Console.WriteLine("After method call, number: " + number);
        System.Console.WriteLine("--------------------------------3--------------------------------------");
        string text = "The quick brown fox jumps over the lazy dog. Email me at example@example.com.";

        // Pattern to match words
        string wordPattern = @"\b\w+\b";
        MatchCollection wordMatches = Regex.Matches(text, wordPattern);

        Console.WriteLine("Words found:");
        foreach (Match match in wordMatches)
        {
            Console.WriteLine(match.Value);
        }

        // Pattern to match email addresses
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,7}\b";
        MatchCollection emailMatches = Regex.Matches(text, emailPattern);

        Console.WriteLine("\nEmail addresses found:");
        foreach (Match match in emailMatches)
        {
            Console.WriteLine(match.Value);
        }
        System.Console.WriteLine("-------------------------4-----------------------------------------------");
        MyNamespace.MyClass myClass = new MyNamespace.MyClass();
        myClass.MyMethod();

        AnotherNamespace.AnotherClass anotherClass = new AnotherNamespace.AnotherClass();
        anotherClass.AnotherMethod();
        System.Console.WriteLine("----------------------------5-------------------------------------------");

    }
    static void PassByValue(int num)
    {
        num = 10;
        Console.WriteLine("Inside method, num: " + num);
    }
    static void PassByReference(ref int num)
    {
        num = 10;
        Console.WriteLine("Inside method, num: " + num);
    }
    
}

