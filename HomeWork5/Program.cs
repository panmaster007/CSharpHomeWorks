bool isWork = true;
Console.Clear();
string mainMenu = $"Если хотите вызвать справку, напишите - /help.{Environment.NewLine}Если хотите завершить работу программы, напишите - exit.{Environment.NewLine}Если хотите очистить терминал, напишите clear.{Environment.NewLine}{Environment.NewLine}Какую задачу хотите проверить?{Environment.NewLine}Напишите номер задачи от 1 до 3: ";

while (isWork)
{
  Console.Write(mainMenu);
  
  var word = Console.ReadLine();
  Console.WriteLine();

  if (word == "1" || word == "2" || word == "3")
  {
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
      case "3":
        {
          Task3_DifferenceBetweenMinAndMax();
          WantToEndTask();
          break;
        }
    }
  }
  else if (word.ToLower() == "e" || word.ToLower() == "exit")
  {
      WantToExit();
  }
  else if (word.ToLower() == "c" || word.ToLower() == "clear")
  {
      WantToClear();
  }
  else if (word.ToLower() == "/help" || word.ToLower() == "h")
  {
      
  }
  else
  {
    
  }
  
}

#region Methods_for_work

void WantToClear()
{
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

int CalculateSumOfNotEvenIndexes(int[] array)
{
  int sum = 0;

  for (int i = 1; i < array.Length; i += 2)
  {
    sum += array[i];
  }

  return sum;
}

int[] FindMinAndMax(int[] array)
{
  int[] minAndMax = new int[2];
  minAndMax[0] = array[0];
  minAndMax[1] = array[1];

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= minAndMax[1])
      minAndMax[1] = array[i];
    else if (array[i] <= minAndMax[0])
      minAndMax[0] = array[i];
  }

  return minAndMax;
}

int CalculateDifference(int firstNumber, int secondNumber)
{
  int difference = 0;
  if (firstNumber > secondNumber)
    difference = firstNumber - secondNumber;
  else
    difference = secondNumber - firstNumber;

  return difference;
}

#endregion

#region Tasks

void Task1_CountOfEven()
{
  int[] array = GetRandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
  int count = CalculateCountOfEven(array);

  if (count != 0)
    Console.WriteLine($"В вашем массиве {string.Join(", ", array)} обнаружилось {count} чётных чисел.");
  else
    Console.WriteLine($"В вашем массиве {string.Join(", ", array)} необнаружились чётные числа.");
}

void Task2_SumOfNotEvenIndexes()
{
  int[] array = GetRandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
  int sum = CalculateSumOfNotEvenIndexes(array);

  if (sum != 0)
    Console.WriteLine($"Сумма всех элементов стоящих на нечётных индексах вашего массива {string.Join(", ", array)} равна {sum}.");
}

void Task3_DifferenceBetweenMinAndMax()
{
  int[] array = GetRandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
  int[] minAndMax = FindMinAndMax(array);
  int difference = CalculateDifference(minAndMax[0], minAndMax[1]);

  Console.WriteLine($"Разница между минимальным и максимальным значение вашего массива {string.Join(", ", array)} равна {difference}");
}

#endregion