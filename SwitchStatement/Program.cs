using System;
namespace SwitchStatement;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number 1: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number 2: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(@"Which operation you want to perform: 
        Addition (+)
        Subtraction (-)
        Multiplication (*)
        Modulus Division (%)
        Division (/)");

        string operation = Console.ReadLine();

        switch(operation){
            case "+":
            {
                Console.WriteLine($"Addition Result {num1}+{num2} = {num1+num2}");
                break;
            }
            case "-":
            {
                Console.WriteLine($"Subtraction Result {num1}-{num2} = {num1-num2}");
                break;
            }
            case "*":
            {
                Console.WriteLine($"Multiplication Result {num1}*{num2} = {num1*num2}");
                break;
            }
            case "%":
            {
                Console.WriteLine($"Modulus Division Result {num1}%{num2} = {num1%num2}");
                break;
            }
            case "/":
            {
                Console.WriteLine($"Division Result {num1}/{num2} = {num1/num2}");
                break;
            }
        }
    }
}