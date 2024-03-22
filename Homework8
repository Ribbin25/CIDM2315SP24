using System.IO.Compression;

namespace Homework8;
class Program
{
    public static void Main(string[] args){
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        int[,] array_2d = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        PrintAllOddNumber(array_2d);

        Console.WriteLine($"\nSum of 2D array: {ElementSum(array_2d)}");

        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2D array: ");
        for(int i = 0; i < Q2_3.GetLength(0); i++){
            for(int j = 0; j < Q2_3.GetLength(1); j++){
                Console.WriteLine(Q2_3[i,j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int ArraySum(int[] int_array){
        int sum = 0;
        foreach (int num in int_array){
            sum += num;
        }
        Console.WriteLine("The Sum of int_array is: " +sum);
        return sum;
    }

    public static void PrintAllOddNumber(int[,] array_2d){
        for(int i= 0; i < array_2d.GetLength(0); i++){
            for(int j = 0; j < array_2d.GetLength(1); j++){
                if(array_2d[i,j] %2 != 0){
                    Console.WriteLine(array_2d[i,j]);
                }
            }
        }
    }

    public static int ElementSum(int[,] array_2d){
        int sum = 0;
        for(int i = 0; i < array_2d.GetLength(0); i++){
            for(int j =0; j <array_2d.GetLength(1); j++){
                sum +=array_2d[i,j];
            }
        }
        return sum;
    }

    public static int[,] DoubleArray(int[,] array_2d){
        int rows = array_2d.GetLength(0);
        int cols = array_2d.GetLength(1);
        int[,] doubled_array = new int[rows,cols];
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                doubled_array[i,j]=array_2d[i,j] *2;
            }
        }
        return doubled_array;
    }
}

