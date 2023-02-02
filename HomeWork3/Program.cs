// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

while (true)
{
  Console.Clear();
  Console.Write("Введите пятизначное число: ");

  int num = 0;
  string s = Console.ReadLine();
  if (int.TryParse(s, out num))
  {
    if (s.Length == 5)
    {
      IsPalindrome(num);
    }
    else Console.WriteLine("Вы ввели не пятизначное число");
  }
  else Console.WriteLine("Вы ввели не число");

  Console.ReadKey();
}

void IsPalindrome(int number)
{
  int first, second, fourth, fifth;
  first = number / 10000;
  int num = number - first * 10000;
  second = num / 1000;
  fifth = num % 10;
  num = num / 10;
  fourth = num % 10;

  if (first == fifth && second == fourth)
  {
    Console.WriteLine($"{number} is palindrome");
  }
  else Console.WriteLine($"{number} is not palindrome");
}

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
while (true)
{
  Console.Clear();
  Console.WriteLine("Введите X, Y, Z координаты первой точки: ");

  int aPointX;
  while (!int.TryParse(Console.ReadLine(), out aPointX)) Console.WriteLine("Вы ввели не число!");
  int aPointY;
  while (!int.TryParse(Console.ReadLine(), out aPointY)) Console.WriteLine("Вы ввели не число!");
  int aPointZ;
  while (!int.TryParse(Console.ReadLine(), out aPointZ)) Console.WriteLine("Вы ввели не число!");

  Console.WriteLine("Введите X, Y, Z координаты второй точки: ");

  int bPointX;
  while (!int.TryParse(Console.ReadLine(), out bPointX)) Console.WriteLine("Вы ввели не число!");
  int bPointY;
  while (!int.TryParse(Console.ReadLine(), out bPointY)) Console.WriteLine("Вы ввели не число!");
  int bPointZ;
  while (!int.TryParse(Console.ReadLine(), out bPointZ)) Console.WriteLine("Вы ввели не число!");

  Console.WriteLine($"Расстояние между точками {getLength(aPointX, bPointX, aPointY, bPointY, aPointZ, bPointZ)}");
  Console.ReadLine();
}

double getLength(int x1, int x2, int y1, int y2, int z1, int z2)
{
  return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
*/
// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
while (true)
{
  Console.Clear(); 
  Console.Write("Введите число: ");

  int N;
  while (!int.TryParse(Console.ReadLine(), out N)) Console.WriteLine("Вы ввели не число");

  int index = 1;
  while (index <= N)
  {
    Console.Write($"{Math.Pow(index, 3)} ");
    index++;
  }
  Console.ReadKey();
}
*/