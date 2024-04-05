using System;
namespace StringManipulation;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Main String: ");
        string longString = Console.ReadLine();
        Console.Write("String to be searched: ");
        string subString = Console.ReadLine();

        int count = 0;
        for(int i=0; i<longString.Length-1; i++){
            for(int j=0; j<subString.Length-1; j++){
                if(longString[i]==subString[j] && longString[i+1]==subString[j+1]){
                    count += 1;
                }
                else{
                    continue;
                }
            }
        }
        Console.WriteLine("String searched count = "+count);
    }
}