internal class Tasks
{
  Methods m = new Methods();

  public void Task47_MakeTwoDimensionArrayOfDoubles()
  {
    string text = $"Вы выбрали задачу номер 1{Environment.NewLine}Задайте двумерный массив, заполненный случайными вещественными числами.{Environment.NewLine}";
    Console.WriteLine(text);

    double[,] array = m.GetTwoDimensionArrayOfDouble(m.ReadInt("первую длину"), m.ReadInt("вторую длину"));
    m.PrintTwoDimensionArrayOfDoubles(array);
    Console.WriteLine();
    m.FillTwoDimensionArrayOfDoubles(array);
    m.PrintTwoDimensionArrayOfDoubles(array);
  }

  public void Task50_ShowArgOnIndexes()
  {
    string text = $"Вы выбрали задачу номер 2{Environment.NewLine}Вывод элемента на выбранной позиции.{Environment.NewLine}";
    Console.WriteLine(text);

    int[,] array = m.GetTwoDimensionArrayOfInts(m.ReadInt("первую длину"), m.ReadInt("вторую длину"));
    m.PrintTwoDimensionArrayOfInts(array);
    Console.WriteLine();
    int[,] newArray = m.FillTwoDimensionArrayOfInts(array, m.ReadInt("минимальное значение наполнения"), m.ReadInt("максимальное значение наполнения"));
    m.PrintTwoDimensionArrayOfInts(newArray);
    Console.WriteLine();
    m.FindElementInArray(newArray);
  } 

  public void Task52_AverageOfColumn()
  {
    string text = $"Вы выбрали задачу номер 3{Environment.NewLine}"
                + $"Нахождение среднего арифметического каждого столбца двумерного массива.{Environment.NewLine}";
    Console.WriteLine(text);

    int[,] array = m.GetTwoDimensionArrayOfInts(m.ReadInt("первую длину"), m.ReadInt("вторую длину"));
    m.PrintTwoDimensionArrayOfInts(array);
    Console.WriteLine();
    int[,] newArray = m.FillTwoDimensionArrayOfInts(array, m.ReadInt("минимальное значение наполнения"), m.ReadInt("максимальное значение наполнения"));
    m.PrintTwoDimensionArrayOfInts(newArray);
    Console.WriteLine();
    m.CalculateAverageOfColumn(newArray);
  }
}

