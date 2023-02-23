// SЗадача №18. Работа в группах
//Напишите программу, которая по заданному номеру четверти, показывает 
//диапазон возможных координат точек в этой четверти (x и y).


int Pront(string message)
{
  System.Console.Write(message);
  int result = Convert.ToInt32(System.Console.ReadLine());
  return result;
}

void number(int B)
{
  switch (B)
  {
    case 1:
    System.Console.WriteLine("x > 0 && y > 0");
    break;

    case 2:
    System.Console.WriteLine("x < 0 && y > 0");
    break;

    case 3:
    System.Console.WriteLine("x < 0 && y < 0");
    break;

    case 4:
    System.Console.WriteLine("x > 0 && y < 0");
    break;

    default:
    System.Console.WriteLine("Не верное значение!");
    break;
  }

}

int x = Pront("Введите четверть -> ");
number(x);