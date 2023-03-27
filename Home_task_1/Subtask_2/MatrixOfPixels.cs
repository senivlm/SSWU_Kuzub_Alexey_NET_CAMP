using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Subtask_2
{
	public class MatrixOfPixels
	{
		private const int _COLS = 8;
		private const int _ROWS = 13;
		private int[,] _matrix;
		private int _longestLineLength;
		private int _longestLineStartIndexCol;
		private int _longestLineStartIndexRow;
		private int _longestLineEndIndexCol;
		private int _longestLineEndIndexRow;
		private int _longestLineElement;

		public MatrixOfPixels()
		{
			_longestLineLength = 1;
			_longestLineStartIndexCol = -1;
			_longestLineStartIndexRow = -1;
			_longestLineEndIndexCol = -1;
			_longestLineEndIndexRow = -1;
			_longestLineElement = -1;
			_matrix = new int[_COLS, _ROWS];
		}

		public void FillMatrix()
		{
			Random rand = new Random();

			for (int i = 0; i < _COLS; i++)
			{
				for (int j = 0; j < _ROWS; j++)
				{
					_matrix[i, j] = rand.Next(0, 17);
				}
			}
		}

		public void SearchLongestHorizontalLine()
		{
			bool isStartIndex;
			int currentLineLength;
			int currentLineStartIndexCol = -1;
			int currentLineStartIndexRow = -1;
			int currentLineEndIndexCol = -1;
			int currentLineEndIndexRow = -1;
			int currentLineElement = -1;

			for (int i = 0; i < _COLS; i++)
			{
				isStartIndex = true;
				currentLineLength = 1;

				for (int j = 1; j < _ROWS; j++)
				{
					if (_matrix[i, j - 1] == _matrix[i, j])
					{
						currentLineLength++;
						currentLineElement = _matrix[i, j];

						if (isStartIndex)
						{
							currentLineStartIndexCol = i;
							currentLineStartIndexRow = j - 1;
							isStartIndex = false;
						}

						currentLineEndIndexCol = i;
						currentLineEndIndexRow = j;

					}
					else
					{
						currentLineLength = 1;
						isStartIndex = true;
					}

					if (currentLineLength > _longestLineLength)
					{
						_longestLineLength = currentLineLength;
						_longestLineElement = currentLineElement;
						_longestLineStartIndexCol = currentLineStartIndexCol;
						_longestLineStartIndexRow = currentLineStartIndexRow;
						_longestLineEndIndexCol = currentLineEndIndexCol;
						_longestLineEndIndexRow = currentLineEndIndexRow;
					}
				}
			}

			if (_longestLineElement == -1)
			{
				Console.WriteLine("Найдовшої горизонтальної лiнiї в матрицi не знайдено!");
			}
			else
			{
				Console.WriteLine($"Найдовша горизонтальна лiнiя в матрицi має колiр " +
				$"{_longestLineElement}, довжину {_longestLineLength}, \n" +
				$"iндекси її початку [{_longestLineStartIndexCol},{_longestLineStartIndexRow}] та " +
				$"кiнця [{_longestLineEndIndexCol},{_longestLineEndIndexRow}]");
			}

			Console.WriteLine();
		}

		public void PrintMatrix()
		{
			Console.WriteLine();

			for (int i = 0; i < _COLS; i++)
			{
				for (int j = 0; j < _ROWS; j++)
				{
					Console.Write(_matrix[i, j] + "\t");
				}

				Console.WriteLine();
			}

			Console.WriteLine();
		}
	}
}
