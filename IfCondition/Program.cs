using System;
namespace IfCondition;

class Program{
    public static void Main(string[] args)
    {
        //get total marks from user
        Console.Write("Enter Your Total Marks: ");
        double totalMark = Convert.ToDouble(Console.ReadLine());
        
        //Evaluate Grade
        if(totalMark>80 && totalMark<=100){
            Console.WriteLine("Grade A");
        }
        else if(totalMark>61 && totalMark<=80){
            Console.WriteLine("Grade B");
        }
        else if(totalMark>36 && totalMark<=60){
            Console.WriteLine("Grade C");
        }
        else if(totalMark<36 && totalMark>=0){
            Console.WriteLine("Grade D");
        }
        else{
            Console.WriteLine("Invalid Input");
        }
    }
}