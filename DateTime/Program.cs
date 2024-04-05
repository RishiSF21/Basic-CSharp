using System;
namespace DateTimeAssignment;

class Program{
    public static void Main(string[] args)
    {
        DateTime getDate = new DateTime(2001,01,21,6,30,55);
        // Console.WriteLine($"Day : {getDate.Day}\nMonth : {getDate.Month}\n{getDate.Year}\n{getDate.Hour}\n{getDate.Minute}\n{getDate.Second}");

        string dateString = getDate.ToString();
        Console.WriteLine(dateString);

        string[] dateSplit = dateString.Split("/");

        for(int i=0; i<dateSplit.Length; i++){
            Console.WriteLine(dateSplit[i]);
        }

        string newDate = "";

        foreach(string dt in dateSplit){
            for(int j=0; j<dt.Length; j++){
                if(dt[j]=='/' || dt[j]==':'){
                    newDate += " ";
                }
    
                else{
                    newDate += dt[j];
                    newDate += "";
                }
            }
        }
        Console.WriteLine(newDate);
        
        
    }
}