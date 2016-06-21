namespace Matrix
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int row = 5, col = 5;
            var matrix1 = new Matrix<int>(row, col);
            

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix1[i, j] = (row * i) + j + 1;
                    
                }

            }

            var matrix2 = new Matrix<int>(row, col);
            row = 5;
            col = 5;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = (i + j);
                }
            }
            Console.WriteLine("First Matrix :");
            Console.WriteLine(matrix1);
            Console.WriteLine("Second Matrix :");
            Console.WriteLine(matrix2);
            Console.WriteLine("First \"-\" Second:");
            Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine("First \"+\" Second:");
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine("First \"*\" Second:");
            Console.WriteLine(matrix1 * matrix2);

        }

    }
}
