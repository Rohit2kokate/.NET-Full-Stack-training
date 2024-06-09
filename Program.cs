using System;
namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int m=20,b=30,c;
            Console.Write("Enter The Number");
            a=Convert.ToInt32(Console.ReadLine());

            if(a%2==0){
                Console.WriteLine("Even Number");
            }
            else{
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("before swapping");
            Console.WriteLine("Number A is"+m);
            Console.WriteLine("Number A is"+b);

            c=m;
            m=b;
            b=c;
            Console.WriteLine("after swapping");
            Console.WriteLine("Number A is"+m);
            Console.WriteLine("Number A is"+b);
        }
    }
}
