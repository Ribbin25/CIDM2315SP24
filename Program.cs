namespace Homework2;

class Program
{
    static void Main(string[] args)
    
    // Q1 Input a grade letter
    {
        Console.Write("Please input a letter grade: ");
        char grade = Console.ReadLine().ToUpper()[0];

        int gpaPoints;

        switch (grade)
        {
            case 'A':
                gpaPoints = 4;
                break;
            case 'B':
                gpaPoints = 3;
                break;
            case 'C':
                gpaPoints = 2;
                break;
            case 'D':
                gpaPoints = 1;
                break;
            case 'F':
                gpaPoints = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }

        Console.WriteLine($"GPA Points: {gpaPoints}");
     
    // Q2 Ask the user to put in 3 numbers and print out the lowest one
            Console.WriteLine("Please input the first num: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please input the second num: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please input the third num: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            int smallest;
            if (num1 <= num2)
            {
                if(num1 <= num3)
                {
                    smallest = num1;
                }
                else
                {
                    smallest = num3;
                }
            }
            else
            {
                if(num2 <= num3)
                {
                    smallest = num2;
                }
                else{
                    smallest = num3;
                }
            }

            Console.WriteLine("The smallest value is: "+ smallest);


    //Q3 Bonus: Input a year to check if it's a Leap year
         Console.WriteLine("Please input a year: ");
            int year = Convert.ToInt16(Console.ReadLine());
            bool isLeapYear= false;

            if(year %4 == 0)
            {
                if(year % 100!=0 || year % 400 ==0)
                {
                    isLeapYear =true;
                }
            }
            if(isLeapYear)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else{
                Console.WriteLine($"{year} is not a Leap Year.");
            }


    }

}
