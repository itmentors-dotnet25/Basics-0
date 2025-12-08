using Basics_0.Services;
using Xunit;

namespace Basics.Test;

public class StringFormatterTest
{
    [Fact]
    public void FormatName_WithValidNames_ReturnsFormattedString()
    {
        // Arrange
        StringFormatter formatter = new StringFormatter();
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
        StringFormatter formatter = new StringFormatter();

        // Act
        formatter.SetPrefix("TEST");
        var result = formatter.FormatName("Jane", "Smith");

        // Assert
        Assert.Equal("TEST: Jane Smith", result);
    }
    
    [Fact]
    public void CreateEmail_WithValidValues_ReturnFormattedEmail()
    {
        StringFormatter formatter = new StringFormatter();
        string userName = "John";
        string domain = "domain.domain";

        var result = formatter.CreateEmail(userName, domain);
        
        Assert.Equal("John@domain.domain", result);
    }

    [Fact]
    public void RepeatString_WithValidValues_ReturnRepeatString()
    {
        StringFormatter formatter = new StringFormatter();
        string input = "String";
        int count = 5;

        var result = formatter.RepeatString(input, count);
        
        Assert.Equal("StringStringStringStringString", result);
    }
};