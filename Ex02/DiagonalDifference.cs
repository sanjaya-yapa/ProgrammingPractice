using System;

namespace ProgrammingPractice.Ex02{
    public class DiagonalDifference
    {
       public void diagonalDifference(List<List<int>> arr)
       {
            int primaryDiagonalSum = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                primaryDiagonalSum += arr[i][i];
            }

            int secondaryDiagonalSum = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                secondaryDiagonalSum += arr[i][arr.Count -1 - i];
            }

            int diagonalDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine("The absolute difference between the sums of the diagonals is: " + diagonalDifference);
       }

       public void execute()
       {
            int size = Convert.ToInt32(Console.ReadLine());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < size; i++)
            {
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new InvalidOperationException("Input cannot be null");
                }
                string[] rowItems = input.Split(' ');
                List<int> row = new List<int>();
                for(int j = 0; j < size; j++)
                {
                    row.Add(Convert.ToInt32(rowItems[j]));
                }
                matrix.Add(row);
            }
            diagonalDifference(matrix);;
       }
    }
}


