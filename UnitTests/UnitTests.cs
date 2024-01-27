namespace UnitTests;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void BreakOnException()
    {
        var enumerable = GetEnumerable().GetAwaiter().GetResult();

        Assert.IsNull(enumerable);
    }
    
    [TestMethod]
    public async Task BreakOnExceptionAsync()
    {
        var enumerable = await GetEnumerable();

        Assert.IsNull(enumerable);
    }

    private static Task<IEnumerable<string>> GetEnumerable()
    {
        var emptyEnumeration = Enumerable.Empty<string>();
        
        return Task.FromResult(emptyEnumeration);
    }
}