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
    public void CreateEmail_CreatedEmailByNameAndDomain()
    {
        // Arrange
        string userName = "username";
        string domain = "domain.ru";
        string email = userName + "@" + domain;

        // Act
        var result = StringFormatter.CreateEmail(userName, domain);

        // Assert
        Assert.Equal(email, result);
    }

    [Fact]
    public void RepeatString_ConcatenateStringSpecifiedNumberOfTimes()
    {
        // Arrange
        string text = ".net";
        int count = 5;
        string expectedText = ".net.net.net.net.net";

        // Act
        var result = StringFormatter.RepeatString(text, count);

        // Assert
        Assert.Equal(expectedText, result);
    }
};