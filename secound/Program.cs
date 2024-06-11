using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("-----------------------------------------------------------------");
        System.Console.Write("0 1");
        for (int i = 0; i < n; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($" {i}");
            }
        }
        System.Console.WriteLine("\n------------------------------------------------------------------");
        System.Console.Write("enter the number factorial");
        int a=int.Parse(Console.ReadLine());
        System.Console.WriteLine("--------------------------------------------------------------------");
        System.Console.WriteLine($"factorial is {facto(a)}");
        System.Console.WriteLine("------------------------------------------------------------------");
        System.Console.Write("enter the first number");
        int Num1=int.Parse(Console.ReadLine());
        System.Console.Write("enter the secound number");
        int Num2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("--------------------------------------------------------------------");
        System.Console.WriteLine($"Before Swapping {Num1}---{Num2}");
        swap(Num1,Num2);
        System.Console.WriteLine("----------------------------------------------------------------------");
        System.Console.Write("Enter How Many Number You Want To Print In Fibnocies Series ?");
        int Number=int.Parse(Console.ReadLine());
        System.Console.WriteLine("\n--------------------------------------------------------------------");
        fib(Number);
        System.Console.WriteLine("\n----------------------------------------------------------------------");
    }

    static void fib(int n){
         int a = 0, b = 1, c;
        if (n >= 1)
        {
            Console.Write(a + " ");
        }
        if (n >= 2)
        {
            Console.Write(b + " ");
        }
        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }

    static void swap(int a,int b){
        a=a+b;
        b=a-b;
        a=a-b;
        System.Console.WriteLine("---------------------------------------------------------------");
        System.Console.WriteLine($"After Swapping number{a}---{b}");
    }
    static int facto(int a){
        
        int fact=1;
        for (int i = 1; i <= a; i++)
        {
            fact=fact*i;
        }
        return fact;
    }


    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        if (number == 2)
        {
            return true;
        }
        if (number % 2 == 0)
        {
            return false;
        }
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
