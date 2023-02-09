bool isWork = true;
while (isWork)
{
  Console.Clear();
  Console.Write("Какое задание вы хотите проверить?\nВведите целое число от 1 до 3\nИли напишите /h для справки\n\nВаш выбор: ");

  var word = Console.ReadLine();
  if (word == "1" || word == "2" || word == "3")
  {
    int.TryParse(word, out var n);
    switch (n)
    {
      case 1: //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        {
          Console.Clear();

          Console.Write("Вы выбрали задачу номер 1\nВывод результата возведения числа А в степень В.\n\nВведите число А: ");
          int a = ReadInt();
          Console.Write("Введите число B: ");
          int b = ReadInt();
          Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {MathPow(a, b)}");

          Console.Write("\nНажмите любую кнопку для возврата в главное меню");
          Console.ReadKey();
          break;
        }

      case 2: //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        {
          Console.Clear();

          Console.Write("Вы выбрали задачу номер 2\nВывод суммы цифр числа.\n\nВведите число: ");
          int number = ReadInt();
          Console.WriteLine($"Сумма всех цифр в числе {number}: {CalculateSumOfDigits(number)}");

          Console.Write("\nНажмите любую кнопку для возврата в главное меню");
          Console.ReadKey();
          break;
        }

      case 3: //Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        {
          Console.Clear();
          Console.Write("Вы выбрали задачу номер 3\nВывод массива из 8 элементов.\n\nНажмите любую кнопку для вывода массива");
          Console.ReadKey();

          int[] array = GetArrayOfInts(8);
          FillArray(array);
          Console.Write($"Ваш случайный массив: ");
          PrintArray(array);

          Console.Write("\nНажмите любую кнопку для возврата в главное меню");
          Console.ReadKey();
          break;
        }

    }

    //default:
    //break;
  }

  else if (word.ToLower() == "/help" || word.ToLower() == "/h")
  {
    Console.Clear();
    Console.Write("Справка:\n1. Вывод результата возведения числа А в степень В.\n2. Вывод суммы цифр числа.\n3. Вывод массива из 8 элементов.\n/help. Справка\nExit или E. Завершение работы программы\n\nДля возврата в главное меню нажмите любую кнопку");
    Console.ReadKey();
  }
  else if (word.ToLower() == "exit" || word.ToLower() == "e" || word.ToLower() == "у")
  {
    isWork = false;
  }
  else
  {
    Console.WriteLine("Неизвестная команда, повторите выбор\n\nНажмите любую кнопку для возврата в главное меню");
    Console.ReadKey();
  }
}


// Методы для первой задачи

int MathPow(int number, int power)
{
  int raisedNumber = number;

  for (int i = 1; i < power; i++) 
  {
    raisedNumber *= number;
  }

  return raisedNumber;
}

// Методы для второй задачи

int CalculateSumOfDigits(int number)
{
  int sumOfDigits = 0;

  while (number > 0)
  {
    sumOfDigits += number % 10;
    number /= 10;
  }

  return sumOfDigits;
}

// Методы для третьей задачи

int[] GetArrayOfInts(int count)
{
  int[] array = new int[count];

  return array;
}

void FillArray(int[] array)
{
  Random random = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(0, 100);
  }
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (i < array.Length - 1)
    {
      Console.Write($"{array[i]}, ");
    }
    else
    {
      Console.Write($"{array[i]}.");
    }
  }
}

// Общие методы

int ReadInt()
{
  int number = 0;

  while (!int.TryParse(Console.ReadLine(), out number))
  {
    Console.Write("Это не целое число! Попробуйте ещё раз: ");
  }

  return number;
}
