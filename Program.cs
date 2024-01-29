using System;

class Program
{
    static void Main()
    {
      
        int[,] matrix = new int[3, 3];
        Console.WriteLine("Please enter matrix values:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("the amount of [{0},{1}]: ", i, j);
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

       
        int determinant = CalculateDeterminant(matrix);

      
        Console.WriteLine("Determinant of the matrix: " + determinant);
    }

   
    static int CalculateDeterminant(int[,] matrix)
    {
        int determinant = 0;

        determinant += matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
        determinant -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
        determinant += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

        return determinant;
    }
}