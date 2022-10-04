namespace Lab1;

internal static class Program
{
    static void Main(string[] args)
    {
        Address randomAddress = new()
        {
            Apartment = 54,
            City = "City",
            Index = 20612,
            House = 27,
            Street = "Malinovskogo",
        };
        
        Console.WriteLine(randomAddress);

        Console.ReadKey(intercept: true);
    }
}