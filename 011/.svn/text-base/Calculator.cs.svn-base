using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace _011
{
  public class Calculator
  {
    public static int FindLargestProductOfFourAdjacentNumbers(int[,] grid)
    {
      int largestProduct = 0;

      for (int column = 0 ; column < grid.GetLength(1) ; column++)
      {
        for (int row = 0 ; row < grid.GetLength(0) ; row++)
        {
          largestProduct = Math.Max(largestProduct, FindLargestProductStartingAt(grid, row, column));
        }
      }

      return largestProduct;
    }

    private static int FindLargestProductStartingAt(int[,] grid, int row, int column)
    {
      int down = CalculateDown(grid, row, column);
      int diagonalDownRight = CalculateDiagonalDownRight(grid, row, column);
      int diagonalDownLeft = CalculateDiagonalDownLeft(grid, row, column);
      int right = CalculateRight(grid, row, column);

      int diagonalMax = Math.Max(diagonalDownLeft, diagonalDownRight);
      int downRightMax = Math.Max(down, right);
      return Math.Max(diagonalMax, downRightMax);
    }

    private static int CalculateDown(int[,] grid, int row, int column)
    {
      if (row < grid.GetLength(0) - 3)
      {
        return grid[row, column] * grid[row + 1, column] * grid[row + 2, column] * grid[row + 3, column];
      }

      return 0;
    }

    private static int CalculateDiagonalDownRight(int[,] grid, int row, int column)
    {
      if ((column < grid.GetLength(1) - 3) && (row < grid.GetLength(0) - 3))
      {
        return grid[row, column] * grid[row + 1, column + 1] * grid[row + 2, column + 2] * grid[row + 3, column + 3];
      }

      return 0;
    }

    private static int CalculateDiagonalDownLeft(int[,] grid, int row, int column)
    {
      if ((column - 3 >= 0) && (row < grid.GetLength(0) - 3))
      {
        return grid[row, column] * grid[row + 1, column - 1] * grid[row + 2, column - 2] * grid[row + 3, column - 3];
      }

      return 0;
    }

    private static int CalculateRight(int[,] grid, int row, int column)
    {
      if (column < grid.GetLength(1) - 3)
      {
        return grid[row, column] * grid[row, column + 1] * grid[row, column + 2] * grid[row, column + 3];
      }

      return 0;
    }
  }
}
