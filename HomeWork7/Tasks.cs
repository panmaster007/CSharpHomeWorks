internal class Tasks
{
  Methods m = new Methods();

  public void Task41_CountOfNumsMoreThanZero_1() // запрос пока пользователь не прервёт ввод
  {
    string text = $"Вы выбрали задачу номер 1{Environment.NewLine}Посчитайте, сколько введено чисел больше 0{Environment.NewLine}"
                + $"Введите необходимое количество чисел по очереди, а в конце введите \"stop\"{Environment.NewLine}";
    Console.WriteLine(text);

    //double result = m.CalculateNumsMoreThanZero();
    //Console.WriteLine($"Вы ввели {result} чисел больше 0.");
  }

  public void Task41_CountOfNumsMoreThanZero_2() // через массив
  {
    string text = $"Вы выбрали задачу номер 2{Environment.NewLine}Посчитать, сколько введено чисел больше 0.{Environment.NewLine}";
    Console.WriteLine(text);

    //double result = m.CalculateNumsMoreThanZeroInArray(m.GetFilledArray(m.ReadFromUser("количество чисел для сравнения")));
    //Console.WriteLine($"Вы ввели {result} чисел больше 0.");
  }

  public void Task52_AverageOfColumn()
  {
    string text = $"Вы выбрали задачу номер 3{Environment.NewLine}"
                + $"Нахождение среднего арифметического каждого столбца двумерного массива.{Environment.NewLine}";
    Console.WriteLine(text);

    int[,] array = m.GetTwoDimensionArray(m.ReadFromUser("первую длину", 1), m.ReadFromUser("вторую длину", 1));
    int[,] newArray = m.FillTwoDimensionArray(array, m.ReadFromUser("минимальное значение наполнения", 1), m.ReadFromUser("максимальное значение наполнения", 1));
    m.CalculateAverageOfColumn(newArray);
  }
}

