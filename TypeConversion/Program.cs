using System;
namespace TypeConversion;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject1: ");
        double mark1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter mark of subject2: ");
        double mark2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter mark of subject3: ");
        double mark3 = Convert.ToDouble(Console.ReadLine());

        double total = mark1+mark2+mark3;

        double avg = (total/3);

        Console.Write("Enter Grade: ");
        char grade = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter mobile number: ");
        long mobile = Convert.ToInt64(Console.ReadLine());

        Console.Write("Enter Mail Id: ");
        string mail = Console.ReadLine();

        Console.WriteLine("Trainee Details Are: ");
        Console.WriteLine($"Name: {name}\nAge: {age}\nMobile: {mobile}\nMarks1: {mark1}\nMarks2: {mark2}\nMarks3: {mark3}");
        Console.WriteLine($"Total: {total}\nAverage: {avg}\nGrade: {grade}\nMail id: {mail}");
    }
}