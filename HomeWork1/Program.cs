Console.Clear();
bool isWork = true;

while (isWork)
{
  Console.Clear();
  Console.Write("Какое задание вы хотите проверить?\nВведите целое число от 1 до 4\nИли напишите /help для справки\n\nВаш выбор: ");

  var word = Console.ReadLine();
  if (word == "1" || word == "2" || word == "3" || word == "4")
  {
    int.TryParse(word, out var n);
    switch (n)
    {
      case 1: //Вывод наибольшего из двух чисел.
        {
          Console.Clear();
          Console.Write("Вы выбрали задачу номер 1\nВывод наибольшего из двух чисел.\n\nВведите первое число: ");

          long.TryParse(Console.ReadLine(), out long a);
          Console.Write($"Введите второе число: ");
          long.TryParse(Console.ReadLine(), out long b);

          long max;
          if (a > b) max = a;
          else max = b;

          Console.WriteLine($"\nНаибольшее число: {max}");
          Console.Write("\nНажмите любую кнопку для возврата в главное меню");
          Console.ReadKey();
          break;
        }

      case 2: //Вывод наибольшего из трёх чисел.
        {
          Console.Clear();
          Console.Write("Вы выбрали задачу номер 2\nВывод наибольшего из трёх чисел.\n\nВведите первое число: ");

          long.TryParse(Console.ReadLine(), out long a);
          Console.Write($"Введите второе число: ");
          long.TryParse(Console.ReadLine(), out long b);
          Console.Write($"Введите третье число: ");
          long.TryParse(Console.ReadLine(), out long c);

          long[] longs = new long[3] { a, b, c };
          long max = a;

          for (int i = 0; i < longs.Length; i++)
          {
            if (max < longs[i]) max = longs[i];
          }

          Console.WriteLine($"\nНаибольшее число: {max}");
          Console.Write("\nНажмите любую кнопку для возврата в главное меню");
          Console.ReadKey();
          break;
        }

      case 3: //Проверка чётности числа.
        {
          Console.Clear();
          Console.Write("Вы выбрали задачу номер 3\nПроверка чётности числа.\n\nВведите число: ");

          long.TryParse(Console.ReadLine(), out long a);
          if (a % 2 == 0 && a != 0) Console.WriteLine($"\nЧисло {a} чётное!"); //Хоть чётность числа 0 очень спорный вопрос, решил убрать из задачь
          else if (a == 0) Console.WriteLine($"\nВ данном решении {a} не рассматривается.");
          else Console.WriteLine($"\nЧисло {a} нечётное!");

          Console.Write("\nНажмите любую кнопку для возврата в главное меню");
          Console.ReadKey();
          break;
        }
      case 4: //Вывод всех чётных чисел от 1 до введённого включительно.
        {
          Console.Clear();
          Console.Write("Вы выбрали задачу номер 4\nВывод всех чётных чисел до введённого включительно.\n\nВведите число: ");

          long.TryParse(Console.ReadLine(), out long a);
          long count = 0;
          if (a > 0)
          {
            Console.Write("Все чётные числа от 1 до N включительно: ");
            for (long i = 1; i <= a; i++)
            {
              if (i == 2)
              {
                Console.Write($"{i}");
                count++;
              }
              else if (i % 2 == 0)
              {
                Console.Write($", {i}");
                count++;
              }
            }
            
            Console.WriteLine($"\nВсего чётных чисел: {count}");
            Console.WriteLine("\nНажмите любую кнопку для возврата в главное меню");
            Console.ReadKey();
          }
          else
          {
            Console.WriteLine("Число меньше минимального\nНажмите любую кнопку для возврата в главное меню");
            Console.ReadKey();
          }
          break;
        }

        //default:
        //break;
    }
  }
  else if (word.ToLower() == "/help")
  {
    Console.Clear();
    Console.Write("Справка:\n1. Вывод наибольшего из двух чисел\n2. Вывод наибольшего из трёх чисел\n3. Проверка чётности числа\n4. Вывод всех чётных чисел от 1 до введённого включительно\n/help. Справка\nExit или E. Завершение работы программы\n\nДля возврата в главное меню нажмите любую кнопку");
    Console.ReadKey();
  }
  else if (word.ToLower() == "exit" || word.ToLower() == "e")
  {
    isWork = false;
  }
  else
  {
    Console.WriteLine("Неизвестная команда, повторите выбор\n\nНажмите любую кнопку для возврата в главное меню");
    Console.ReadKey();
  }
}