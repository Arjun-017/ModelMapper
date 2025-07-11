using System.Diagnostics;

namespace TestApplication;

public class Program
{
    public static void Main()
    {
        var person = new Person() { Id = 1, Name = "John" };

        var sw = Stopwatch.StartNew();
        for (int i = 0; i < 10000; i++)
        {
            person.MapToEmployee();
        }
        sw.Stop();
        Console.WriteLine($"Time ellapsed for quick mapping - {sw.Elapsed.TotalMilliseconds} ms");

        sw = Stopwatch.StartNew();
        for (int i = 0; i < 10000; i++)
        {
            var employee = SlowMapper.SlowMapper.Map<Person, Employee>(person);
        }
        sw.Stop();
        Console.WriteLine($"Time ellapsed for slow mapping - {sw.Elapsed.TotalMilliseconds} ms");
    }
}
