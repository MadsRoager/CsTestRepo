using System;
namespace Leap {
public class LeapYear {

    public static void Main(string[] args)
{
    Console.WriteLine("Enter a year: ");
    LeapYear leapYear = new LeapYear();
    int year = int.Parse(Console.ReadLine());
    bool isLeapYear = leapYear.IsLeapYear(year);
    if(isLeapYear) {
        Console.WriteLine("yay");
    } else {
        Console.WriteLine("nay");
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

