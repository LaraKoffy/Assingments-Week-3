namespace Nr8
{
    internal class Program
    {
        static int CalculateSum(int count)
        {
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Decrement to repeat the current iteration
                }
            }

            return sum;
        }

        static double CalculateAverage(int sum, int count)
        {
            return (double)sum / count;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of integers you want to calculate:");

            if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
            {
                Console.WriteLine(" Please enter a valid positive integer.");
                return;
            }

            Console.WriteLine("\nLet's calculate the sum and average:");

            int sum = CalculateSum(count);
            double average = CalculateAverage(sum, count);

            Console.WriteLine($"\nTotal sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
        }
    }
}
