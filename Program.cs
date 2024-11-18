namespace Assignment3_2_1
{
    internal class Program
    {
        // Create a 2D array to store integers and print them in matrix format with proper formatting.
        static void Main(string[] args)
        {
            int[,] twoDIntArr = {{2, 3, 4 },
                                 {1, 4, 6 }};

            MatrixPrint(twoDIntArr);
        }

        // Nested for loop with correct formatting on console print
        static void MatrixPrint(int[,] twoDIntArr)
        {
            for (int i = 0; i < twoDIntArr.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write("|");
                for(int j = 0; j < twoDIntArr.GetLength(1); j++)
                {
                    Console.Write($" { twoDIntArr[i, j] } |");
                }
            }
        }
    }
}
