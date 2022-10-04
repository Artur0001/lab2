namespace Employee;

internal static class Program
{
    static void Main(string[] args)
    {
        Employee tester = new Employee("Ihor", "Korzh")
        {
            EmployeeType = EmployeeType.Tester,
            Experience = 5
        };
        
        Console.WriteLine(tester);
        
        Console.ReadKey(true);
    }
}