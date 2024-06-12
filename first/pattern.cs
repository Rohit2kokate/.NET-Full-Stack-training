using System;
using System.Reflection.Metadata.Ecma335;
namespace first_project
{
    public static class Pattern
    {
        public static int right(int length){
            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
            }
            return 0;
        }

        public static int invert(int rows){
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            return 0;
        }
        public static int left(int length){
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    System.Console.Write("*");

                }
                System.Console.WriteLine();
                
            }
            return 0;
        }
        public static int rectangle(int len,int breath){
                int area=len*breath;
                return area;
        }

        public static double polygoan(int p,int a){

            int s=p*a;
            double area=(0.5)*s;
            return area;
        }
    }
}