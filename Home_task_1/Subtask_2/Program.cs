using System;

namespace Subtask_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			string isContinue = "yes";

			while (isContinue == "yes")
			{
				MatrixOfPixels matrixOfPixels = new MatrixOfPixels();
				matrixOfPixels.FillMatrix();
				matrixOfPixels.PrintMatrix();
				matrixOfPixels.SearchLongestHorizontalLine();

				Console.Write("Введiть yes, якщо хочете повторити виконання програми: ");
				isContinue = Console.ReadLine();
			}

			Console.ReadKey();
		}
	}
}
