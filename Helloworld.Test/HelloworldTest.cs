namespace Helloworld.Test;

public class HelloworldTest
{
    [Fact]
    public void ouputShouldWriteHelloworld()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Helloworld;

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");
    }
}