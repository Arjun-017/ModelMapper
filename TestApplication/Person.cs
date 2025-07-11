using QuickMapper.Common.Attributes;

namespace TestApplication;

[MapTo(typeof(Employee))]
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}
