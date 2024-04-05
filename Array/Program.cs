using System;
namespace Array;

class Program
{
    public static void Main(string[] args)
    {
        string[] names = new string[5] { "rishi", "scofield", "ragnar", "jon snow", "gokul" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.Write("Enter a name to search: ");
        string search = Console.ReadLine();
        bool flag=true;

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == search)
            {
                Console.WriteLine("The name is present in array" + " Index position is: " + i);
                flag = false;
            }
        }
        if(flag){
            Console.WriteLine("The name is not present in array");
        }
        

        foreach(string name in names){
            if(name==search){
                flag = false;
                Console.WriteLine("The name is present in array");
            }
        }
        if(flag){
            Console.WriteLine("The name is not present in array");
        }
    }
}