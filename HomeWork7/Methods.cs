public class Methods
{
  #region MethodsForTasks

  public double ReadDouble(string arg)
  {
    Console.Write($"Введите {arg}: ");
    double num;

    while (!double.TryParse(Console.ReadLine(), out num))
    {
      Console.Write("Значение не подходит, повторите: ");
    }

    return num;
  }

  public int ReadInt(string arg)
  {
    Console.Write($"Введите {arg}: ");
    int num;

    while (!int.TryParse(Console.ReadLine(), out num))
    {
      Console.Write("Значение не подходит, повторите: ");
    }

    return num;
  }

  public void PrintTwoDimensionArrayOfInts(int[,] array)
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

  public void PrintTwoDimensionArrayOfDoubles(double[,] array)
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

  public int[,] GetTwoDimensionArrayOfInts(int firstLength, int secondLength)
  {
    int[,] array = new int[firstLength, secondLength];

    Console.WriteLine($"Ваш массив {firstLength}*{secondLength} готов:");
    return array;
  }

  public double[,] GetTwoDimensionArrayOfDouble(int firstLength, int secondLength)
  {
    double[,] array = new double[firstLength, secondLength];

    Console.WriteLine($"Ваш массив {firstLength}*{secondLength} готов:");
    return array;
  }

  public void FillTwoDimensionArrayOfDoubles(double[,] array)
  {
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (random.Next(-1, 1) < 0)
        {
          array[i, j] = -Math.Round(random.NextDouble() * 10, 1);
        }
        else
        {
          array[i, j] = Math.Round(random.NextDouble() * 10, 1);
        }
      }
    }

    Console.WriteLine($"Заполнил ваш массив:");
  }

  public int[,] FillTwoDimensionArrayOfInts(int[,] array, int minValue, int maxValue)
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
    return newArray;
  }

  public void FindElementInArray(int[,] array)
  {
    int firstIndex = 0;
    int secondIndex = 0;
    bool isTrue = true;

    while (isTrue)
    {      
      firstIndex = ReadInt("первый индекс");
      secondIndex = ReadInt("второй индекс");

      if (firstIndex <= array.GetLength(0) && secondIndex <= array.GetLength(1))
      {
        Console.WriteLine($"Элемент позиции [{firstIndex}, {secondIndex}] - {array[firstIndex  - 1, secondIndex - 1]}");
      }
      else
      {
        Console.Write("Нет такого элемента!");
        isTrue = false;
      }
    }
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


