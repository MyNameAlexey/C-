// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

bool pifagor (int AB, int BC, int AC)
{
  bool result = true;
  if(AB >= BC + AC ) result = false;
  if(BC >= AB + AC ) result = false;
  if(AC >= BC + AB ) result = false;

  return result;
}

System.Console.WriteLine("Введите AB: ");
int ab = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите AC: ");
int ac = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите BC: ");
int bc = Convert.ToInt32(Console.ReadLine());

if (pifagor (ab, ac, bc))
{
  System.Console.WriteLine("Теорема верна! ");
} 
else
{
  System.Console.WriteLine("Теорема неверна! ");
}