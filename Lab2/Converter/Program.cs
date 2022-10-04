namespace Converter;

class Program
{
    private const decimal USD = 42M;
    private const decimal EUR = 41M;
    private const decimal GBP = 50M;

    static void Main(string[] args)
    {
        Converter converter = new(USD, EUR, GBP);

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Enter the amount of money in UAH: ");
            var amount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Choose the currency to convert: ");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. GBP");

            var currency = int.Parse(Console.ReadLine());
            var resultText = currency switch
            {
                1 => $"You will get {converter.ConvertToUSD(amount)} USD",
                2 => $"You will get {converter.ConvertToEUR(amount)} EUR",
                3 => $"You will get {converter.ConvertToGBP(amount)} GBP",
                _ => "Error"
            };

            Console.WriteLine(resultText);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}