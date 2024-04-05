using System;
namespace ForLoop;

class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number limit to find the sum of squares: \nEnter Number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i=num1; i<num2; i++){
            
            int square = i*i;
            sum += square;
            
        }
        Console.WriteLine(sum);
    }
}