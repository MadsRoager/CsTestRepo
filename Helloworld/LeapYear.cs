using System;
namespace Leap {
public class LeapYear {

    public static void Main(string[] args)
{
    Console.WriteLine("Enter a year: ");
    LeapYear leapYear = new LeapYear();

    int year = 0;
    try {
        year = int.Parse(Console.ReadLine());
    } catch (FormatException) {
        Console.WriteLine("Error: Please insert a year as an integer");
        System.Environment.Exit(0);
    }
    
    if(year >= 1582) {
        bool isLeapYear = leapYear.IsLeapYear(year);
        if(isLeapYear) {
            Console.WriteLine("yay");
        } else {
            Console.WriteLine("nay");
        }
    } else {
        Console.WriteLine("Error: That year is before 1582");
    }
}
    public bool IsLeapYear(int year) {
        if(year % 100 == 0) {
            if(year % 400 == 0) {
                return true;
            }
            return false;
        }
        return year % 4 == 0;
    }
}
}

