namespace Homework5;

public class Largest1
{
   //Q1 2 integers and return the largest
    public static int largest(int n1, int n2)
    {
        if(n1>n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    public static void Main(string[] args)
   {
    Console.Write("a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The largest number is: "+ largest(a,b));

   }

}
Q2 4 integers and return the largest 
public class Largest2
{
    public static int largest(int n1, int n2)
    {
        if(n1>n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }
    public static void Main(string[] args)
    {
        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("d: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: "+ largest(a,b,c,d));

    }
}

Q3
   class Program
    {
        static void Main()
        {
            createAccount();
        }
        public static bool checkAge(int birth_year)
        {
            if((2024-birth_year)>=18)
            return true;
        
            else
                return false;
            }
        public static void createAccount()
        {
            Console.Write("Enter Your Username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Your Password Again: ");
            string confirm_password = Console.ReadLine();
            Console.Write("Enter Your Birthyear: ");
            int birth_year = Convert.ToInt32(Console.ReadLine());
            if(checkAge(birth_year))
            {
                if(password==confirm_password)
                Console.WriteLine("Account is created Sucessfully");
            
            else
                Console.WriteLine("Wrong password");
            
            }
            else{
                Console.WriteLine("Could not create an account");
            }

        }
    }
        
    










    





