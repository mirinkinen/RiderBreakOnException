try
{
    var array = Array.Empty<int>();
    var item = array[0]; // Stops even when "Only break on exceptions thrown from user code" is enabled.
    //var item = array.First(); // Does not stop when "Only break on exceptions thrown from user code" is enabled.

    Console.WriteLine("item: " + item);
}
catch (Exception ex)
{
    Console.WriteLine("Caught.");
}