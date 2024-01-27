using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        var enumerable = GetEnumerable();
    
        Assert.IsNull(enumerable);
    }
    
    private static IEnumerable<string> GetEnumerable()
    {
        return Enumerable.Empty<string>();
    }
}