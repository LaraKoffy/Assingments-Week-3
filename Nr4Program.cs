namespace Nr4
{
    internal class Program
    {
        static (int evenCount, int oddCount) CountEvenAndOdd(int start, int end)
        {
            int evenCount = 0;
            int oddCount = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            return (evenCount, oddCount);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the starting number:");
            if (!int.TryParse(Console.ReadLine(), out int start))
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return;
            }

            Console.WriteLine("Enter the ending number:");
            if (!int.TryParse(Console.ReadLine(), out int end))
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return;
            }

            if (start > end)
            {
                Console.WriteLine(" The starting number must be less than or equal to the ending number.");
                return;
            }

            var (evenCount, oddCount) = CountEvenAndOdd(start, end);

            
            Console.WriteLine($"Between {start} and {end}:");
            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
        }
    }
}

