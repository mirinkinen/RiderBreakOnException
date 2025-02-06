using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatchedExceptions;

public class Program
{
    /// <summary>
    /// Demonstrates scenarios where Rider stops on exception depending on the setting "Only break on exceptions thrown from user code".
    /// Disable the setting to break on all exceptions.
    /// </summary>
    public static async Task Main(string[] args)
    {
        try
        {
            // Uncomment methods to test.

            //ExceptionThrownInMyCode();
            //ExceptionThrownInThirdPartyCode();
            //await ExceptionThrownInMyCodeAsync();
            //await ExceptionThrownInThirdPartyCodeAsync();
            //ExceptionThrownFromIndexOperator();
            //ExceptionThrownFromEnumerableFirst();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catched");
        }
    }

    public static void ExceptionThrownInMyCode()
    {
        throw new Exception("Test");
    }

    /// <summary>
    /// Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    public static void ExceptionThrownInThirdPartyCode()
    {
        Assert.IsNotNull(null);
    }

    public static async Task ExceptionThrownInMyCodeAsync()
    {
        await Task.Delay(10);

        throw new Exception("Test");
    }

    /// <summary>
    /// Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    public static async Task ExceptionThrownInThirdPartyCodeAsync()
    {
        await Task.Delay(10);

        Assert.IsNotNull(null);
    }

    /// <summary>
    /// Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    public static void ExceptionThrownFromIndexOperator()
    {
        var list = new List<string>();
        var item = list[0];
    }

    /// <summary>
    /// Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
    /// </summary>
    public static void ExceptionThrownFromEnumerableFirst()
    {
        var list = new List<string>();
        var item = list.First();
    }
}