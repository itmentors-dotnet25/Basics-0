using Basics_0.Services;
using Xunit;

namespace Basics.Test;

public class StringFormatterTest
{
    [Fact]
    public void FormatName_WithValidNames_ReturnsFormattedString()
    {
        // Arrange
        var formatter = new StringFormatter();
        string firstName = "John";
        string lastName = "Doe";

        // Act
        var result = formatter.FormatName(firstName, lastName);

        // Assert
        Assert.Equal("DEFAULT: John Doe", result);
    }

    [Fact]
    public void SetPrefix_ChangesPrefixInFormatting()
    {
        // Arrange
        var formatter = new StringFormatter();

        // Act
        formatter.SetPrefix("TEST");
        var result = formatter.FormatName("Jane", "Smith");

        // Assert
        Assert.Equal("TEST: Jane Smith", result);
    }

    [Fact]
    public void CreatEmailWithUserNameAndDomain()
    {
        // Arrange
        string userName = "John_Doe";
        string domain = "mail.ru";

        // Act
        var result = StringFormatter.CreateEmail(userName, domain);

        // Assert
        Assert.Equal("John_Doe@mail.ru", result);
    }

    [Fact]
    public void RepeatStringTest()
    {
        // Arrange
        string text = "TestLine_";
        int count = 7;

        // Act
        var result = StringFormatter.RepeatString(text, count);

        // Assert
        Assert.Equal("TestLine_TestLine_TestLine_TestLine_TestLine_TestLine_TestLine_", result);

    }

};