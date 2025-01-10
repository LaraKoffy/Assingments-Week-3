namespace Nr3
{
    internal class Program
    {
        static void PrintMultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to generate its multiplication table:");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                PrintMultiplicationTable(number);
            }
        }
    }
}
