namespace Nr7
{
    internal class Program
    {
        static void PrintSquare(int dimensionSize)
        {
            for (int i = 0; i < dimensionSize; i++)
            {
                for (int j = 0; j < dimensionSize; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the size of the square dimension:");

                if (!int.TryParse(Console.ReadLine(), out int dimensionSize) || dimensionSize <= 0)
                {
                    Console.WriteLine(" Please enter a valid positive number.");
                    return;
                }

                Console.WriteLine($"\nSquare pattern of size {dimensionSize}x{dimensionSize}:\n");
                PrintSquare(dimensionSize);
            }
        }
    }
}
