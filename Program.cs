﻿namespace Homework3;

class Program
{
    static void Main(string[] args)
   
    { //Q1 Prime number
        bool flag = true;
        Console.Write("Input an interger:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        for(int i=2; i<number/2; i++)
        {
            if(number%i==0)
            {
                flag=false;
                break;
            }
        }

        if(flag)
        {
            Console.WriteLine( input + " is Prime");
        }
        else{
            Console.WriteLine( input + " is non-Prime");

    //Q2 #input integer N

        Console.WriteLine("Assign an int value to N:");
        int n =  int.Parse(Console.ReadLine());

        for(int i =0; i<n; i++){
        
        for(int j =0; j<n; j++){
            Console.Write("#");
        }
            Console.WriteLine(); 
        

    //Q3 *input integer N
        Console.WriteLine("Assign an int value to N:");
        int N =Convert.ToInt16(Console.ReadLine());
        for(int i =0; i<N; i++){
       
        for(int j=0;j<N;j++){
        
        if(i<j)
            Console.Write(" ");
        else
        
            Console.Write("*");
        }
            Console.WriteLine("\n");
        

    
    //Bonus
        int x, y, z, n;
        Console.WriteLine ("Assignment an int value to n: ");
        n= Convert.ToInt32(Console.ReadLine());
        for (x=1; x <=n; x++){

        for (y=0; y<n-x; y++ ){
            Console.Write(" ");
        }
        for (z=1; z<=x; z++){
            Console.Write(x);
        }
            Console.WriteLine();

        }

    }
}

    