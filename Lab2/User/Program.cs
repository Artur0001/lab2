internal static class Program
{
    static void Main(string[] args)
    {
        User user = new User("JohnDoe1994", "John", "Doe", DateTime.Now.Year - 1994);
        
        Console.WriteLine(user);
    }
}