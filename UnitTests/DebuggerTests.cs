namespace UnitTests;

[TestClass]
public class DebuggerTests
{
    [TestMethod]
    public void ExceptionThrownInMyCode()
    {
        throw new Exception("Test");
    }

    /// <summary>
    /// Does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    [TestMethod]
    public void ExceptionThrownInThirdPartyCode()
    {
        Assert.IsNotNull(null);
    }

    [TestMethod]
    public async Task ExceptionThrownInMyCodeAsync()
    {
        await Task.Delay(10);

        throw new Exception("Test");
    }

    /// <summary>
    /// Does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    [TestMethod]
    public async Task ExceptionThrownInThirdPartyCodeAsync()
    {
        await Task.Delay(10);

        Assert.IsNotNull(null);
    }

    /// <summary>
    /// Does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    [TestMethod]
    public void ExceptionThrownFromIndexOperator()
    {
        var list = new List<string>();
        var item = list[0];
    }

    /// <summary>
    /// Does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    [TestMethod]
    public void ExceptionThrownFromEnumerableFirst()
    {
        var list = new List<string>();
        var item = list.First();
    }
}