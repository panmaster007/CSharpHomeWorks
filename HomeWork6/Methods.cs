
public class Methods
{
	#region MethodsForTasks

	public double ReadFromUser(string arg)
	{
		Console.Write($"Введите {arg}: ");
		double num;
		
		while (!double.TryParse(Console.ReadLine(), out num))
		{
			Console.Write("Значение не подходит, повторите: ");
		}

		return num;
	}

	public double[] GetFilledArray(double length)
	{
		double[] array = new double[(int)length];

		for (int i = 0; i < array.Length; i++)
		{
			array[i] = ReadFromUser($"значение на позиции {i + 1}");
		}

		return array;
	}

	public double CalculateNumsMoreThanZero()
	{
		bool isWork = true;
		double result = 0;

		while (isWork)
		{
			Console.Write("Введите число: ");
			string s = Console.ReadLine();
			double num = 0;

			if (s.ToLower() == "s" || s.ToLower() == "stop" || s.ToLower() == "ы")
			{
				isWork = false;
			}
			else if (!double.TryParse(s, out num))
			{
				Console.WriteLine("Значение не подходит, повторите.");
			}

			if (num > 0) result++;
		}

		return result;
	}

	public double CalculateNumsMoreThanZeroInArray(double[] array)
	{
		double count = 0;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] > 0) count++;
		}

		return count;
	}

	public double FindXOfCross(double k1, double b1, double k2, double b2)
	{
		return (b1 - b2) / (-k1 + k2);
	}

	public double FindYOfCross(double k, double b, double x)
	{
		return k * x + b;
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
  	string text = $"Справка:{Environment.NewLine}1. Посчитать, сколько введено чисел больше 0.{Environment.NewLine}"
								+ $"2. Нахождение точки пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.{Environment.NewLine}"
								+ $"/help или /h. Справка{Environment.NewLine}Exit или E. Завершение работы программы";

  	Console.Clear();
  	Console.WriteLine(text);
  	ToEndTask();
		Console.Clear();
	}

	#endregion
}