﻿using System;
namespace first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int a;
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
            Console.WriteLine("Number A is"+b);*/

            Console.WriteLine("Enter The First number");
            int  a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Secound number");
            int b=Convert.ToInt32(Console.ReadLine());

            int c,d,e;
            c=a+b;
            d=a*b;
            e=a-b;
            Console.WriteLine("Multiplication is"+d);
            Console.WriteLine("Subtraction"+e);
            Console.WriteLine("Addition Is"+c);


        }
    }
}
