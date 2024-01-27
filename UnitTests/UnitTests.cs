namespace UnitTests;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void BreakOnException()
    {
        var enumerable = GetEnumerable();

        Assert.IsNull(enumerable);
    }
    
    [TestMethod]
    public async Task BreakOnExceptionAsync()
    {
        var enumerable = GetEnumerable();

        Assert.IsNull(enumerable);
    }

    private static IEnumerable<string> GetEnumerable()
    {
        return Enumerable.Empty<string>();
    }
}