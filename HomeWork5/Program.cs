bool isWork = true;
Console.Clear();
string mainMenu = $"Если хотите вызвать справку, напишите - /help.{Environment.NewLine}Если хотите завершить работу программы, напишите - exit.{Environment.NewLine}{Environment.NewLine}Какую задачу хотите проверить?{Environment.NewLine}Напишите номер задачи от 1 до 3: ";

while (isWork)
{
  Console.Write(mainMenu);
  
  var word = Console.ReadLine();
  Console.WriteLine();

  if (word == "1" || word == "2" || word == "3")
    switch (word)
    {
      case "1":
        {
          Task1_CountOfEven();
          WantToEndTask();
          break;
        }

      case "2": 
        {
          Task2_SumOfNotEvenIndexes();
          WantToEndTask();
          break;
        }
    }
}

#region Methods_for_work

void WantToClear()
{
  Console.ReadKey();
  Console.Clear();
}

void WantToExit()
{
  isWork = false;
}

void WantToEndTask()
{
  Console.Write($"{Environment.NewLine}Для возврата в главное меню, нажмите любую кнопку");
  Console.ReadKey();
}

#endregion

#region Methods_for_tasks

int[] GetRandomArray(int length, int minValue, int maxValue)
{
  int[] array = new int[length];
  Random random = new Random();

  for (int i = 0;i < array.Length; i++)
  {
    array[i] = random.Next(minValue, maxValue + 1);
  }

  return array;
}

int CalculateCountOfEven(int[] array)
{
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
      count++;
  }

  return count;
}

#endregion

#region Tasks

int ReadInt(string arg)
{
  int number;
  Console.Write($"Введите {arg}: ");

  while (!int.TryParse(Console.ReadLine(), out number))
  {
    Console.Write("Значение не является целым числом, повторите: ");
  }

  return number;
}

void Task1_CountOfEven()
{
  int[] array = GetRandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
  int count = CalculateCountOfEven(array);

  if (count != 0)
    Console.WriteLine($"В вашем массиве {string.Join(", ", array)} обнаружилось {count} чётных чисел.");
  else
    Console.WriteLine($"В вашем массиве {string.Join(", ", array)} необнаружились чётные числа.");
}

void Task2_SumOfNotEvenIndexes(int[] array)
{
  int[] array = GetRandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
  int sum = 
}
#endregion