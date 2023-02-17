public class Methods
{
  #region MethodsForTasks

  public double ReadFromUser(string arg)
  {
    Console.Write($"Введите {arg}: ");
    double num;

    while (!double.TryParse(Console.ReadLine(), out num))
    {
      Console.Write("Значение не подходит, повторите: ");
    }

    return num;
  }

  public int ReadFromUser(string arg, int iUseless)
  {
    Console.Write($"Введите {arg}: ");
    int num;

    while (!int.TryParse(Console.ReadLine(), out num))
    {
      Console.Write("Значение не подходит, повторите: ");
    }

    return num;
  }

  public void PrintTwoDimensionArray(int[,] array)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i, j]} ");
      }

      Console.WriteLine();
    }
  }

	public void PrintTwoDimensionArray(double[,] array, int kUseless)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Console.Write($"{array[i, j]} ");
			}

			Console.WriteLine();
		}
	}

  public int[,] GetTwoDimensionArray(int firstLength, int secondLength)
  {
    int[,] array = new int[firstLength, secondLength];

    Console.WriteLine($"Ваш массив {firstLength}*{secondLength} готов:");
    PrintTwoDimensionArray(array);
		Console.WriteLine();
    return array;
  }

  public double[,] FillTwoDimensionArray(int[,] array)
  {
    Random random = new Random();
    double[,] newArray = new double[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        newArray[i, j] = random.NextDouble();
      }
    }

    Console.WriteLine($"{Environment.NewLine}Заполнил ваш массив:");
    PrintTwoDimensionArray(newArray, 1);
		Console.WriteLine();
    return newArray;
  }

  public int[,] FillTwoDimensionArray(int[,] array, int minValue, int maxValue)
  {
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        newArray[i, j] = random.Next(minValue, maxValue + 1);
      }
    }

    Console.WriteLine($"Заполнил ваш массив:");
    PrintTwoDimensionArray(newArray);
		Console.WriteLine();
    return newArray;
  }

  public void CalculateAverageOfColumn(int[,] array)
  {
    double resultX = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
      resultX = 0;

      for (int j = 0; j < array.GetLength(0); j++)
      {
        resultX += array[j, i];
      }

			resultX /= array.GetLength(0);
      Console.WriteLine($"Среднее арифметическое {i + 1} столбца: {Math.Round(resultX, 1)}");
    }
  }

  #endregion

  #region MethodsForWork

  public void ToEndTask()
  {
    Console.WriteLine($"{Environment.NewLine}Для возврата в главное меню, нажмите любую кнопку{Environment.NewLine}");
    Console.ReadKey();
  }

  public void ToHelp()
  {
    Console.Clear();
    string text = $"Справка:{Environment.NewLine}1. Посчитать, сколько введено чисел больше 0.{Environment.NewLine}"
                + $"2. Нахождение точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.{Environment.NewLine}"
                + $"/help или /h. Справка{Environment.NewLine}Exit или E. Завершение работы программы";

    Console.WriteLine(text);
    ToEndTask();
    Console.Clear();
  }

  #endregion
}


