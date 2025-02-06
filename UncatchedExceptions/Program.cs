using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UncatchedExceptions;

public class Program
{
    /// <summary>
    /// Demonstrates scenarios where Rider always stops on exception regardless of the "Only break on exceptions thrown from user code"
    /// setting.
    /// </summary>
    public static async Task Main(string[] args)
    {
        //ExceptionThrownInMyCode();
        //ExceptionThrownInThirdPartyCode();
        //await ExceptionThrownInMyCodeAsync();
        //await ExceptionThrownInThirdPartyCodeAsync();
        //ExceptionThrownFromIndexOperator();
        //ExceptionThrownFromEnumerableFirst();
    }

    public static void ExceptionThrownInMyCode()
    {
        throw new Exception("Test");
    }

    public static void ExceptionThrownInThirdPartyCode()
    {
        Assert.IsNotNull(null);
    }

    public static async Task ExceptionThrownInMyCodeAsync()
    {
        await Task.Delay(10);

        throw new Exception("Test");
    }

    public static async Task ExceptionThrownInThirdPartyCodeAsync()
    {
        await Task.Delay(10);

        Assert.IsNotNull(null);
    }

    public static void ExceptionThrownFromIndexOperator()
    {
        var list = new List<string>();
        var item = list[0];
    }

    public static void ExceptionThrownFromEnumerableFirst()
    {
        var list = new List<string>();
        var item = list.First();
    }
}