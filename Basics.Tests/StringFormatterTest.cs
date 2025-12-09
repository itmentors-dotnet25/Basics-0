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
        var firstName = "John";
        var lastName = "Doe";

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

    // === Дополнительные тесты для FormatName ===

    [Fact]
    public void FormatName_WithEmptyFirstName_ReturnsCorrectFormat()
    {
        // Arrange
        var formatter = new StringFormatter();

        // Act
        var result = formatter.FormatName("", "Doe");

        // Assert
        Assert.Equal("DEFAULT:  Doe", result); // пробел перед "Doe"
    }

    [Fact]
    public void FormatName_WithEmptyLastName_ReturnsCorrectFormat()
    {
        // Arrange
        var formatter = new StringFormatter();

        // Act
        var result = formatter.FormatName("John", "");

        // Assert
        Assert.Equal("DEFAULT: John ", result);
    }

    [Fact]
    public void FormatName_WithBothNamesEmpty_ReturnsCorrectFormat()
    {
        // Arrange
        var formatter = new StringFormatter();

        // Act
        var result = formatter.FormatName("", "");

        // Assert
        Assert.Equal("DEFAULT:  ", result);
    }

    [Fact]
    public void FormatName_AfterSetPrefixToNull_UsesEmptyStringAsPrefix()
    {
        // Arrange
        var formatter = new StringFormatter();
        formatter.SetPrefix(null);

        // Act
        var result = formatter.FormatName("A", "B");

        // Assert
        Assert.Equal(": A B", result); // null → ""
    }

    // === Тесты для CreateEmail ===

    [Fact]
    public void CreateEmail_WithValidUserNameAndDomain_ReturnsCorrectEmail()
    {
        // Act
        var email = StringFormatter.CreateEmail("john.doe", "example.com");

        // Assert
        Assert.Equal("john.doe@example.com", email);
    }

    [Fact]
    public void CreateEmail_WithEmptyUserName_ReturnsEmailStartingWithAt()
    {
        // Act
        var email = StringFormatter.CreateEmail("", "example.com");

        // Assert
        Assert.Equal("@example.com", email);
    }

    [Fact]
    public void CreateEmail_WithEmptyDomain_ReturnsEmailEndingWithAt()
    {
        // Act
        var email = StringFormatter.CreateEmail("user", "");

        // Assert
        Assert.Equal("user@", email);
    }

    [Fact]
    public void CreateEmail_WithBothEmpty_ReturnsOnlyAt()
    {
        // Act
        var email = StringFormatter.CreateEmail("", "");

        // Assert
        Assert.Equal("@", email);
    }

    // === Тесты для RepeatString ===

    [Fact]
    public void RepeatString_WithPositiveCount_RepeatsCorrectly()
    {
        // Act
        var result = StringFormatter.RepeatString("abc", 3);

        // Assert
        Assert.Equal("abcabcabc", result);
    }

    [Fact]
    public void RepeatString_WithZeroCount_ReturnsEmptyString()
    {
        // Act
        var result = StringFormatter.RepeatString("abc", 0);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void RepeatString_WithNegativeCount_ReturnsEmptyString()
    {
        // Act
        var result = StringFormatter.RepeatString("abc", -5);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void RepeatString_WithEmptyInput_ReturnsEmptyString()
    {
        // Act
        var result = StringFormatter.RepeatString("", 5);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void RepeatString_WithNullInput_ReturnsEmptyString()
    {
        // Act
        var result = StringFormatter.RepeatString(string.Empty, 3);

        // Assert
        Assert.Equal("", result);
    }

    [Fact]
    public void RepeatString_WithSingleCharacter_RepeatsCorrectly()
    {
        // Act
        var result = StringFormatter.RepeatString("x", 4);

        // Assert
        Assert.Equal("xxxx", result);
    }

    // === Дополнительно: проверка независимости экземпляров ===

    [Fact]
    public void MultipleInstances_DoNotInterfereWithEachOther()
    {
        // Arrange
        var formatter1 = new StringFormatter();
        var formatter2 = new StringFormatter();

        // Act
        formatter1.SetPrefix("A");
        formatter2.SetPrefix("B");

        var result1 = formatter1.FormatName("X", "Y");
        var result2 = formatter2.FormatName("X", "Y");

        // Assert
        Assert.Equal("A: X Y", result1);
        Assert.Equal("B: X Y", result2);
    }
}
