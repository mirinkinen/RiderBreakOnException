using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UncatchedExceptions;

public class Program
{
    /// <summary>
    /// Rider always stops when the setting "Only break on exceptions thrown from user code" is disabled.
    /// For other scenarios, see: https://www.jetbrains.com/help/rider/Debugging_Exceptions.html
    /// </summary>
    public static async Task Main(string[] args)
    {
        // ExceptionThrownInMyCode();
        // ExceptionThrownInThirdPartyCode();
        // await ExceptionThrownInMyCodeAsync();
        // await ExceptionThrownInThirdPartyCodeAsync();
        // ExceptionThrownFromListIndexOperator();
        // ExceptionThrownFromListEnumerableFirst();
        // ExceptionThrownFromArrayIndexOperator();
        // ExceptionThrownFromArrayEnumerableFirst();
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

    public static void ExceptionThrownFromListIndexOperator()
    {
        var list = new List<int>();
        var item = list[0];
    }

    public static void ExceptionThrownFromListEnumerableFirst()
    {
        var list = new List<int>();
        var item = list.First();
    }
    
    public static void ExceptionThrownFromArrayIndexOperator()
    {
        var array = Array.Empty<int>();
        var item = array[0];
    }

    public static void ExceptionThrownFromArrayEnumerableFirst()
    {
        var array = Array.Empty<int>();
        var item = array.First();
    }
}