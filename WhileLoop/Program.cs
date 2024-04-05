using System;
namespace WhileLoop;

class Program{
    public static void Main(string[] args)
    {
        //Question 1
        // int number = 0;
        // while(number<25){
        //     number += 2;
        //     if(number<25){
        //         Console.WriteLine(number);
        //     }
            
        
        // }
        //Question 2
       // int num;
        bool valid = false;

        while(valid==false){
            valid = int.TryParse(Console.ReadLine(),out int num);
            if(valid==true){
                Console.WriteLine(num);
                break;
            }
            else{
                Console.WriteLine("Invalid Input");
            }
            
        }
    }
}