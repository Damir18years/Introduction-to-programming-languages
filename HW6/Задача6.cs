// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine ("Введите числа:");
string numbers = Console.ReadLine();
// нам нужно перебрать каждый элемент строки, если это не запятая или пробел, кладм его в массив, если запятая или пробле. делаем ++
string [] newNumbers = new string [numbers.Length];
int k = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    k++;
  }
  else
  {
    newNumbers[k] = newNumbers[k]+$"{numbers[i]}";
  }
}
k++;
int [] resultNumbers = new int[k];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < k; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0: "+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine ("Введите коэффициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите коэффициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
Console.WriteLine (x);
double y = k1*x+b1;
Console.WriteLine ("Точка пересечения 2-х прямых с заданными коэффициентами k и b имеет координаты:  ("+x+","+y+")");