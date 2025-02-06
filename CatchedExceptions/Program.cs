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
            //ExceptionThrownFromListIndexOperator();
            //ExceptionThrownFromListEnumerableFirst();
            //ExceptionThrownFromArrayIndexOperator();
            //ExceptionThrownFromArrayEnumerableFirst();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Catched");
        }
    }

    /// <summary>
    /// Rider always stops on exception.
    /// </summary>
    public static void ExceptionThrownInMyCode()
    {
        throw new Exception("Test");
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    public static void ExceptionThrownInThirdPartyCode()
    {
        Assert.IsNotNull(null);
    }

    /// <summary>
    /// Rider always stops on exception.
    /// </summary>
    public static async Task ExceptionThrownInMyCodeAsync()
    {
        await Task.Delay(10);

        throw new Exception("Test");
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    public static async Task ExceptionThrownInThirdPartyCodeAsync()
    {
        await Task.Delay(10);

        Assert.IsNotNull(null);
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    public static void ExceptionThrownFromListIndexOperator()
    {
        var list = new List<int>();
        var item = list[0];
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    public static void ExceptionThrownFromListEnumerableFirst()
    {
        var list = new List<int>();
        var item = list.First();
    }
    
    /// <summary>
    /// Rider always stops on exception.
    /// </summary>
    public static void ExceptionThrownFromArrayIndexOperator()
    {
        var array = Array.Empty<int>();
        var item = array[0];
    }

    /// <summary>
    /// Rider stops only when "Only break on exceptions thrown from user code" is disabled.
    /// </summary>
    public static void ExceptionThrownFromArrayEnumerableFirst()
    {
        var array = Array.Empty<int>();
        var item = array.First();
    }
}