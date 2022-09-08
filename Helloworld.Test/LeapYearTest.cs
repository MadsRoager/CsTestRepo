using Leap;
namespace LeapYearTest;

public class LeapYearTest
{
    [Fact]
    public void LeapYearDivisibleByFour()
    {
        //Arrange
        LeapYear leapYear = new LeapYear();

        //Act
        bool leapYearBool = leapYear.IsLeapYear(4);

        //Assert
        leapYearBool.Should().Be(true);
    }

    [Fact]
    public void LeapYearNotDivisibleByFour() {
        //Arrange
        LeapYear leapYear = new LeapYear();

        //Act
        bool leapYearBool = leapYear.IsLeapYear(5);

        //Assert
        leapYearBool.Should().Be(false);
    }

    [Fact]
    public void DivisibleBy100NotLeapYear() {
        //Arrange
        LeapYear leapYear = new LeapYear();

        //Act
        bool leapYearBool = leapYear.IsLeapYear(100);

        //Assert
        leapYearBool.Should().Be(false);
    }

    [Fact]
    public void DivisibleBy400IsLeapYear() {
        //Arrange
        LeapYear leapYear = new LeapYear();

        //Act
        bool leapYearBool = leapYear.IsLeapYear(400);
        bool eightHundredBool = leapYear.IsLeapYear(800);

        //Assert
        leapYearBool.Should().Be(true);
        eightHundredBool.Should().Be(true);
    }

    [Fact]
    public void YearBefore1582() {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        LeapYear.Main(Array.Empty<string>());
        writer.WriteLine("1581");
        Console.WriteLine("1581");

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Error: That year is before 1582");
    }
}