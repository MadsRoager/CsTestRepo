
namespace Leap {
public class LeapYear {

    public static void Main(string[] args)
{
    
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

