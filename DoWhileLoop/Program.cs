using System;
namespace DoWhileLoop;

class Program{
    public static void Main(string[] args)
    {
        string runAgain;
        
        do{
            Console.Write("Enter a Number: ");
            int getNumber = Convert.ToInt32(Console.ReadLine());
            if(getNumber>0){
                if(getNumber%2==0){
                    Console.WriteLine($"Entered number {getNumber} is Even");
                }
                else{
                    Console.WriteLine($"Entered number {getNumber} is Odd");
                }
            }
            Console.Write("Do you want to enter different number? (yes/no)");
            runAgain = Console.ReadLine();
            if(runAgain!="yes" && runAgain!="no"){
                Console.WriteLine("Invalid Input..try again");
                continue;
            }
            else if(runAgain=="no"){
                break;
            }
            else{}

        }while(runAgain=="yes");
    }
}