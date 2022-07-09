using FluentAssertions;

namespace GadgetoComparerTests;
public class UnitTest1
{
    [Theory]
    [InlineData("", "")]
    public void Test1(object subject, object objectToCompare)
    {
        bool test = GadgetoComparer.GadgetoComparer.CompareProperties(subject, objectToCompare, new (),out object? result, out string message);
        test.Should().BeTrue();
        result.Should().BeNull();
        message.Should().BeEmpty();
    }
}
