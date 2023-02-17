Console.Clear();

Tasks t = new Tasks();
Methods m = new Methods();

bool isWork = true;
string mainMenuText = $"Если хотите вызвать справку, напишите - /help.{Environment.NewLine}"
                    + $"Если хотите завершить работу программы, напишите - exit.{Environment.NewLine}"
                    + $"Если хотите очистить терминал, напишите clear.{Environment.NewLine}{Environment.NewLine}"
                    + $"Какую задачу хотите проверить?{Environment.NewLine}Напишите номер задачи от 1 до 3: ";

while (isWork)
{
  Console.Write(mainMenuText);
  string word = Console.ReadLine();
  Console.WriteLine();

  if (word == "1" || word == "2" || word == "3")
  {
    switch (word)
    {
      case "1":
      {
        t.Task47_MakeTwoDimensionArrayOfDoubles();
        m.ToEndTask();
        break;
      }
      case "2":
      {
        t.Task50_ShowArgOnIndexes();
        m.ToEndTask();
        break;
      }
      case "3":
      {
        t.Task52_AverageOfColumn();
        m.ToEndTask();
        break;
      }
    }
  }
  else if (word.ToLower() == "e" || word.ToLower() == "exit" || word.ToLower() == "у")
  {
    isWork = false;
  }
  else if (word.ToLower() == "c" || word.ToLower() == "clear" || word.ToLower() == "с")
  {
    Console.Clear();
  }
  else if (word.ToLower() == "/help" || word.ToLower() == "h" || word.ToLower() == "р")
  {
    m.ToHelp();
  }
  else
  {
    Console.WriteLine($"Команда не была распознана, повторите ввод{Environment.NewLine}");
  }
}