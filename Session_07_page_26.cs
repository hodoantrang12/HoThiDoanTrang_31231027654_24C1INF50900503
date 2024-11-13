internal class Session_07
{
    static void Main(string[] args)
    {
        // Prompt user for matrix dimensions
        Console.Write("Nhap so dong (N): ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Nhap so cot (M): ");
        int M = int.Parse(Console.ReadLine());

        // Initialize and fill the matrix with user input
        int[,] matrix = new int[N, M];
        Console.WriteLine("Nhap gia tri:");

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write($"a[{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Print the matrix
        Console.WriteLine("Matrix:");
        PrintMatrix(matrix, N, M);

        // Prompt user for row/column to print
        Console.Write("Enter the row/column index (i): ");
        int iIndex = int.Parse(Console.ReadLine());

        // Print the i-th row
        Console.WriteLine($"Row {iIndex}:");
        PrintRow(matrix, iIndex, M);

        // Print the i-th column
        Console.WriteLine($"Column {iIndex}:");
        PrintColumn(matrix, iIndex, N);

        // Find and print the max value of the matrix
        int maxValue = FindMaxValue(matrix, N, M);
        Console.WriteLine($"Max value of the matrix: {maxValue}");

        // Find and print the min value of the i-th row/column
        int minRowValue = FindMinValueInRow(matrix, iIndex, M);
        int minColValue = FindMinValueInColumn(matrix, iIndex, N);
        Console.WriteLine($"Min value of row {iIndex}: {minRowValue}");
        Console.WriteLine($"Min value of column {iIndex}: {minColValue}");

        // Transpose and print the matrix
        int[,] transposedMatrix = TransposeMatrix(matrix, N, M);
        Console.WriteLine("Transposed Matrix:");
        PrintMatrix(transposedMatrix, M, N);

        // Print the main diagonal (if square)
        if (N == M)
        {
            Console.WriteLine("Main diagonal values:");
            PrintMainDiagonal(matrix, N);
            Console.WriteLine("Secondary diagonal values:");
            PrintSecondaryDiagonal(matrix, N);
        }
        else
        {
            Console.WriteLine("Matrix is not square, so no main/secondary diagonal values.");
        }
    }

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintRow(int[,] matrix, int row, int cols)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[row, j] + "\t");
        }
        Console.WriteLine();
    }

    static void PrintColumn(int[,] matrix, int col, int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(matrix[i, col]);
        }
    }

    static int FindMaxValue(int[,] matrix, int rows, int cols)
    {
        int max = matrix[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }

    static int FindMinValueInRow(int[,] matrix, int row, int cols)
    {
        int min = matrix[row, 0];
        for (int j = 1; j < cols; j++)
        {
            if (matrix[row, j] < min)
            {
                min = matrix[row, j];
            }
        }
        return min;
    }

    static int FindMinValueInColumn(int[,] matrix, int col, int rows)
    {
        int min = matrix[0, col];
        for (int i = 1; i < rows; i++)
        {
            if (matrix[i, col] < min)
            {
                min = matrix[i, col];
            }
        }
        return min;
    }

    static int[,] TransposeMatrix(int[,] matrix, int rows, int cols)
    {
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }

    static void PrintMainDiagonal(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(matrix[i, i] + "\t");
        }
        Console.WriteLine();
    }

    static void PrintSecondaryDiagonal(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(matrix[i, size - i - 1] + "\t");
        }
        Console.WriteLine();
    }
}