namespace Nr2
{
    internal class Program
    {
        static int CalculateFactorial(int n)
        {
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i; 
            }

            return factorial;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer to calculate its factorial:");

            if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
            {
                int result = CalculateFactorial(n);
                Console.WriteLine($"The factorial of {n} is: {result}");
            }
            
        }
    }
}
