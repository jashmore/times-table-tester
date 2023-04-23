using FluentAssertions;
using TimesTableTester.Services;
using Xunit;

namespace TimesTableTester.Tests;

public class TimesTableTestServiceTests
{
    private readonly TimesTableTestService _sut = new();
    private readonly Random _random = new();
    
    [Fact]
    public void When_Invoked_GenerateMultiplier_Returns_Multiplier_InCorrectRange()
    {
        // Arrange
        for (var index = 0; index <= 100; index++)
        {
            // Act
            var multiplier = _sut.GenerateMultiplier();

            // Assert
            multiplier.Should().BeGreaterThanOrEqualTo(1);
            multiplier.Should().BeLessThanOrEqualTo(Constants.MaxMultiplier);    
        }
    }
}