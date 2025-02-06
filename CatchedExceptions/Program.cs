using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatchedExceptions;

public class Program
{
    /// <summary>
    /// Demonstrates scenarios where Rider does not stop on exceptions. Visual Studio does stop on all exceptions. This causes confusion
    /// to people coming from Visual Studio.
    /// </summary>
    public static async Task Main(string[] args)
    {
        try
        {
            // Uncomment methods to test.
            
            ExceptionThrownInMyCode();
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

    public static void ExceptionThrownInThirdPartyCode()
    {
        // Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
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

        // Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
        Assert.IsNotNull(null);
    }

    public static void ExceptionThrownFromIndexOperator()
    {
        var list = new List<string>();
        
        // Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
        var item = list[0];
    }

    public static void ExceptionThrownFromEnumerableFirst()
    {
        var list = new List<string>();
        
        // Rider does not stop when "Only break on exceptions thrown from user code" is enabled.
        var item = list.First();
    }
}