using System;

namespace Subtask_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введiть кiлькiсть рядкiв матрицi: ");
				int cols = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введiть кiлькiсть стовпцiв матрицi: ");
				int rows = Convert.ToInt32(Console.ReadLine());

				SpiralSnakeMatrix spiralSnakeMatrix = new SpiralSnakeMatrix(cols, rows);
				spiralSnakeMatrix.FillMatrix();
				spiralSnakeMatrix.PrintMatrix();
			}
			catch
			{
				Console.WriteLine("Кiлькiсть стовпцiв i рядкiв має бути числом!");
			}

			Console.ReadKey();
		}
	}
}
