namespace Nr6
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is prime:");

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Error: Please enter a valid integer.");
                return;
            }

            if (IsPrime(number))
                Console.WriteLine($"{number} is a prime number.");
            else
                Console.WriteLine($"{number} is not a prime number.");
        }
    }
}
