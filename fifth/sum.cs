namespace fifth_Project
{
    public static class Sum
    {
        public static int sum(){
            Console.WriteLine("Enter the Element of Array");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Element of Array");
            int m=int.Parse(Console.ReadLine());

            int[,] a=new int[m,n];
            int[,] b=new int[m,n];
            System.Console.WriteLine("Eneter the element of a");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i,j]=int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("Enter the element of b");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                     b[i,j]=int.Parse(Console.ReadLine());
                }
            }
            int[,] arr=new int[m,n];
            System.Console.WriteLine("Addition is");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                     arr[i,j]=a[i,j]+b[i,j];
                }
            }
            System.Console.WriteLine("sum of two arrray is");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    System.Console.Write(" "+arr[i,j]);  
                }
                System.Console.WriteLine();
            }
            return 0;
        }
    }
    
}