// Här har jag min grundläggande klass
public class Hospital
{
    public string Name;
    public string Location;
    public int Departments;

    public void Describe()
    {
        Console.WriteLine($"This hospital is named {Name} and is located in {Location} and has {Departments} different departmens!");
    }
}