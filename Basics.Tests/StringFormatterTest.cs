using Basics.Services;
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
    public void CreateEmail_WithValidInputs_ReturnsCorrectEmail()
    {
        // Arrange
        string userName = "berezin";
        string domain = "misha.ru";

        // Act
        var result = StringFormatter.CreateEmail(userName, domain);

        // Assert
        Assert.Equal("berezin@misha.ru", result);
    }

    [Fact]
    public void RepeatString_WithPositiveCount_ReturnsRepeatedString()
    {
        // Arrange
        string input = "abc";
        int count = 3;

        // Act
        var result = StringFormatter.RepeatString(input, count);

        // Assert
        Assert.Equal("abcabcabc", result);
    }
};
