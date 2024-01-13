using System.Collections;

namespace TestProject1;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public async Task DoesNotBreakOnExceptionAsync()
    {
        var queryable = await GetQueryableAsync();

        Assert.IsNull(queryable);
    }
    
    [TestMethod]
    public void DoesNotBreakOnException()
    {
        var queryable = GetQueryableAsync().Result;

        Assert.IsNull(queryable);
    }

    private async Task<IEnumerable> GetQueryableAsync()
    {
        await Task.Delay(100);
        return Enumerable.Empty<object>();
    }
}