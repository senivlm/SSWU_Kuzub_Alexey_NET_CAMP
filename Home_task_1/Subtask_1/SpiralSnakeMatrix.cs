using System;

namespace Subtask_1
{
	public class SpiralSnakeMatrix
	{
		private int _n;
		private int _m;
		private int[,] _matrix;

		public SpiralSnakeMatrix(int cols, int rows) => CreateNewMatrix(cols, rows);
	

		public void CreateNewMatrix(int cols, int rows)
		{
			if (cols > 0 && rows > 0)
			{
				_n = cols;
				_m = rows;
				_matrix = new int[_n, _m];
			}
			else
			{
				Console.WriteLine("Число стовпцiв i рядкiв має бути позитивним!");
			}
		}

		public void FillMatrix()
		{
			int filler = 1;
			int counter = 0;

			while (filler < _n * _m)
			{
				// Заповнити матрицю поелементно вниз
				for (int j = 0; j < _n; j++)
				{
					if (_matrix[j, counter] == 0)
					{
						_matrix[j, counter] = filler++;
					}
				}

				// Заповнити матрицю поелементно вправо
				for (int j = 0; j < _m; j++)
				{
					if (_matrix[_n - 1 - counter, j] == 0)
					{
						_matrix[_n - 1 - counter, j] = filler++;
					}
				}

				// Заповнити матрицю поелементно вгору
				for (int j = _n - 1; j >= 0; j--)
				{
					if (_matrix[j, _m - 1 - counter] == 0)
					{
						_matrix[j, _m - 1 - counter] = filler++;
					}
				}

				// Заповнити матрицю поелементно вліво
				for (int j = _m - 1; j >= 0; j--)
				{
					if (_matrix[counter, j] == 0)
					{
						_matrix[counter, j] = filler++;
					}
				}

				counter++;
			}
		}

		public void PrintMatrix()
		{
			Console.WriteLine();

			for (int i = 0; i < _n; i++)
			{
				for (int j = 0; j < _m; j++)
				{
					Console.Write(_matrix[i, j] + "\t");
				}

				Console.WriteLine();
			}

			Console.WriteLine();
		}
	}
}
