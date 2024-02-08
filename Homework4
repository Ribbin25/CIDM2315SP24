namespace Homework4;

class Program
{
  //  Q1 2 input and return the largest one
    static int large_num(int a, int b)
    {
    if(a>b){
        return a;
    }
    else{
        return b;
    }
    }
    
     static void Main()
     {
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int result = large_num(a,b);
        Console.WriteLine("The largest number is: "+result);
     } 
}

  // Q2 an integer number N and a shape
class TrianglePrinter
    {
    static void Main()
    {
        Console.WriteLine("Enter an integer N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the shape (left or right): ");
        string shape = Console.ReadLine();

        if(shape.ToLower() == "left")
        {
            PrintLeftTriangle(N);
        }
        else if (shape.ToLower() == "right")
        {
            PrintRightTriangle(N);
        }
        else
        {
            Console.WriteLine("Wrong shape. Please enter 'left' or 'right'.");
        }
    }
    static void PrintLeftTriangle(int N)
    {
        Console.WriteLine($"N is: {N}, Shape is: Left");
        for(int i =1; i<=N; i++)
        {
            for (int j=1; j<=i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
     static void PrintRightTriangle(int N)
    {
        Console.WriteLine($"N is: {N}, Shape is: Right");
        for(int i =1; i<=N; i++)
        {
            for(int j=1; j<=N - i; j++)
            {
                Console.Write("  ";)
            }

            for (int k=1; k<=i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

}








