namespace Nr5
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

      
        static int Subtract(int a, int b)
        {
            return a - b;
        }

     
        static int Multiply(int a, int b)
        {
            return a * b;
        }

      
        static double Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN;
            }
            return (double)a / b;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nSimple Calculator Menu:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");
        }

       
        static void PerformCalculation()
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                DisplayMenu();

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine(" Please select a valid option.");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                Console.Write("Enter the first number: ");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine(" Please enter an number.");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine(" Please enter an number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Result: {num1} + {num2} = {Add(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Result: {num1} - {num2} = {Subtract(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Result: {num1} * {num2} = {Multiply(num1, num2)}");
                        break;
                    case 4:
                        double result = Divide(num1, num2);
                        if (!double.IsNaN(result))
                        {
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator");
            PerformCalculation();
        }
    }
}
