using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so hang:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap so cot:");
        int cols = int.Parse(Console.ReadLine());

        double[,] matrix = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhap gia tri cho phan tu [{i},{j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double maxElement = matrix[0, 0];
        int maxRow = 0;
        int maxCol = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }
        Console.WriteLine($"Phan tu lon nhat la {maxElement}.");
        Console.WriteLine($"Vi tri lon nhat la [{maxRow},{maxCol}].");
    }
}
