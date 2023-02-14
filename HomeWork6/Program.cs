Tasks t = new Tasks();
Methods m = new Methods();

bool isWork = true;
Console.Clear();
string mainMenuText = $"Если хотите вызвать справку, напишите - /help.{Environment.NewLine}"
                    + $"Если хотите завершить работу программы, напишите - exit.{Environment.NewLine}"
                    + $"Если хотите очистить терминал, напишите clear.{Environment.NewLine}{Environment.NewLine}"
                    + $"Какую задачу хотите проверить?{Environment.NewLine}Напишите номер задачи от 1 до 2: ";

while (isWork)
{
  Console.Write(mainMenuText);

  var word = Console.ReadLine();
  Console.WriteLine();

  if (word == "1" || word == "2")
  {
    switch (word)
    {
      case "1":
      {
        t.Task41_CountOfNumsMoreThanZero_1();
        //t.Task41_CountOfNumsMoreThanZero_2();
        m.ToEndTask();
        break;
      }
      case "2":
      {
        t.Task43_FindPointOfCross();
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
  else if (word.ToLower() == "/help" || word.ToLower() == "h")
  {
    m.ToHelp();
  }
  else
  {
    Console.WriteLine($"Команда не была распознана, повторите ввод{Environment.NewLine}");
  }
}