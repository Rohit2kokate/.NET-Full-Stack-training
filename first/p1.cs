using System.Threading;
using System;
namespace first_project
{
    public static class P1{
        public static string man(){
                string Sa="Rohit Kokate";

                for (int i = 0; i < Sa.Length; i++)
                {
                    Console.Write(Sa[i]);
                    Thread.Sleep(200);
                }
                return Sa;
        }
    }
}