using System.Collections;

namespace TestProject1;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public async Task DoesNotBreakOnExceptionAsync()
    {
        var enumerable = await GetEnumerableAsync();

        Assert.IsNull(enumerable);
    }
    
    [TestMethod]
    public void DoesNotBreakOnException()
    {
        var queryable = GetEnumerableAsync().Result;

        Assert.IsNull(queryable);
    }

    private async Task<IEnumerable> GetEnumerableAsync()
    {
        await Task.Delay(100);
        return Enumerable.Empty<object>();
    }
}