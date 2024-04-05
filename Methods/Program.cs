using System;
namespace Methods;

class Program{
    public static void Main(string[] args)
    {
        int Addition(int x, int y){
            return x+y;
        }

        int Sub(int x, int y){
            return x-y;
        }

        int Multiplication(int x, int y){
            return x*y;
        }

        int Division(int x, int y){
            return x/y;
        }

        string user="";
        do{
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Any Operation To Perform:\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            string operation = Console.ReadLine();
            switch(operation){
            case "Addition":{
                Console.WriteLine(Addition(num1,num2));
                break;
            }
            case "Subtraction":{
                Console.WriteLine(Sub(num1,num2));
                break;
            }
            case "Multiplication":{
                Console.WriteLine(Multiplication(num1,num2));
                break;
            }
            case "Division":{
                Console.WriteLine(Division(num1,num2));
                break;
            }
        }
        Console.WriteLine("Do you want to run again (yes/no):");
        user = Console.ReadLine();
        }while(user == "yes");
        
    }
}