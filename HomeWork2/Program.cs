// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
if (int.TryParse(Console.ReadLine(), out int num))
{
  int numTest = num;
  int count = 0;
  while (numTest > 0)
  {
    numTest = numTest / 10;
    count++;
  }

  if (count == 3)
  {
    int result = num / 10 % 10;
    Console.WriteLine(result);
  }
  else Console.WriteLine("Число не трёхзначное!");
}
else Console.WriteLine("Вы ввели не число!");

// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите число: ");
// if (int.TryParse(Console.ReadLine(), out int num))
// {
//   int numTest = num;
//   int count = 0;
//   while (numTest > 0)
//   {
//     numTest = numTest / 10;
//     count++;
//   }

//   if (count == 3)
//   {
//     int result = num % 10;
//     Console.WriteLine(result);
//   }
//   else Console.WriteLine("Число не трёхзначное!");
// }
// else Console.WriteLine("Вы ввели не число!");

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите день недели(число): ");
// if (int.TryParse(Console.ReadLine(), out int num))
// {
//   if (num == 6 || num == 7) Console.WriteLine("Сегодня ВЫХОДНОЙ!!!!!");
//   else if (num > 7 || num < 1) Console.WriteLine("Нет такого дня недели!");
//   else Console.WriteLine("Опять работать!");
// }
// else Console.WriteLine("Вы ввели не число!");