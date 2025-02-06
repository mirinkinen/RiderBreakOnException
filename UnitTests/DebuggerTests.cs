namespace UnitTests;

[TestClass]
public class DebuggerTests
{
    /// <summary>
    /// Rider always stops on exception.
    /// </summary>
    [TestMethod]
    public void ExceptionThrownInMyCode()
    {
        throw new Exception("Test");
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    [TestMethod]
    public void ExceptionThrownInThirdPartyCode()
    {
        Assert.IsNotNull(null);
    }

    /// <summary>
    /// Rider always stops on exception.
    /// </summary>
    [TestMethod]
    public async Task ExceptionThrownInMyCodeAsync()
    {
        await Task.Delay(10);

        throw new Exception("Test");
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    [TestMethod]
    public async Task ExceptionThrownInThirdPartyCodeAsync()
    {
        await Task.Delay(10);

        Assert.IsNotNull(null);
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    [TestMethod]
    public void ExceptionThrownFromIndexOperator()
    {
        var list = new List<string>();
        var item = list[0];
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    [TestMethod]
    public void ExceptionThrownFromEnumerableFirst()
    {
        var list = new List<string>();
        var item = list.First();
    }
}