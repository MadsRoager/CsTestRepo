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
        var program = Assembly.Load(nameof(Helloworld));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");
    }

    [Fact]
    public void randomTest() 
    {
        
    }
}