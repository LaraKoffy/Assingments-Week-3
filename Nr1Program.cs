namespace Nr1
{
    internal class Program
    {
        static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a postive number:");

                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    int result = CalculateSum(n);
                    Console.WriteLine($"The sum of natural numbers from 1 to {n} is: {result}");
                }
            }
        }
    }
}
