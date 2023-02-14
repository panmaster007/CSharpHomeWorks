internal class Tasks
{
  Methods m = new Methods();

  public void Task41_CountOfNumsMoreThanZero_1() // запрос пока пользователь не прервёт ввод
  {
    string text = $"Вы выбрали задачу номер 1{Environment.NewLine}Посчитайте, сколько введено чисел больше 0{Environment.NewLine}"
                + $"Введите необходимое количество чисел по очереди, а в конце введите \"stop\"{Environment.NewLine}";
    Console.WriteLine(text);

    double result = m.CalculateNumsMoreThanZero();
    Console.WriteLine($"Вы ввели {result} чисел больше 0.");
  }

  public void Task41_CountOfNumsMoreThanZero_2() // через массив
  {
    string text = $"Вы выбрали задачу номер 1{Environment.NewLine}Посчитать, сколько введено чисел больше 0.{Environment.NewLine}";
    Console.WriteLine(text);

    double result = m.CalculateNumsMoreThanZeroInArray(m.GetFilledArray(m.ReadFromUser("количество чисел для сравнения")));
    Console.WriteLine($"Вы ввели {result} чисел больше 0.");
  }

  public void Task43_FindPointOfCross()
  {
    string text = $"Вы выбрали задачу номер 2{Environment.NewLine}"
                + $"Нахождение точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.{Environment.NewLine}";
    Console.WriteLine(text);

    double k1 = m.ReadFromUser("значение k1");
    double b1 = m.ReadFromUser("значение b1");
    double k2 = m.ReadFromUser("значение k2");
    double b2 = m.ReadFromUser("значение b2");
    double x = m.FindXOfCross(k1, b1, k2, b2);
    Console.WriteLine($"x = {x}");
    double y = m.FindYOfCross(k2, b2, x);
    Console.WriteLine($"y = {y}");

    if (k1 == k2 && b1 == b2)
    {
      Console.WriteLine("Прямые совпадают!");
    }
    else if (k1 == k2)
    {
      Console.WriteLine("Прямые не пересекаются!");
    }
    else
    {
      Console.WriteLine($"Координаты точки пересечения прямых ({x}, {y}).");
    }
  }
}

