// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Numbers(int number)
{
    while (number > 99999 || number <= 9999)
    {
        Console.WriteLine("Вы ввели неверное число. Попробуйте снова.");
        Console.Write("Введите пятизначное число, и мы проверим является ли оно палиндромом: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    int num1 = number % 10;
    int num2 = number / 10 % 10;
    int num4 = number / 1000 % 10;
    int num5 = number / 10000 % 10;
    if (num1 == num5)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Число является полиндромом");
        }
        else Console.WriteLine("Число НЕявляется полиндромом!");
    }
    else Console.WriteLine("Число НЕявляется полиндромом!");

}

Console.Write("Введите пятизначное число, и мы проверим является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

Numbers(number);*/

// Задача 19 - 2. Напишите программу, которая принимает на вход ЛЮБОЕ число и проверяет, является ли оно палиндромом.
int[] NumbersToArray(int number) // преобразуем в массив
{
    string str = number.ToString();
    int[] num = new int[str.Length];
    int i = 0;
    while (i < str.Length) // Заполняем массив числами
    {
        if (i < str.Length)
        {
            num[i] = str[i];
        }
        i++;
    }
    return num;
}
void Check(int[] array)
{
    int length = array.Length;
    int index = 0;
    int result = 0;
    while (index < length)
    {
        if (array[index] != array[length - 1])
        {
            result = -1;
            break;
        }
        result = 0;
        index++;
        length--;
    }
    if (result == 0) Console.Write("Число полиндром");
    if (result == -1) Console.Write("Число НЕполиндром");
}

Console.Write("Введите число, и мы проверим является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = NumbersToArray(number);
Check(array);

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Distance (double xa, double xb, double ya, double yb, double za, double zb)
{
    double lenth = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
    return lenth;
}

Console.Write("Введите значение координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение координаты Х точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки B: ");
int zb = Convert.ToInt32(Console.ReadLine());



double lenth = Distance(xa, xb, ya, yb, za, zb);
Console.WriteLine($"Растояние между A и B = {lenth}");

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubsNumbers(int number)
{
    if (number < 0)
    {
        Console.WriteLine("Вы ввели отрицательное число, поэтому мы сами его преобразовали в положительное ;)");
        number = number * -1;
    }
    if (number == 0)
    {
        Console.WriteLine("Вы ввели 0, чисел нет!");
    }
    int count = 1;
    while (count <= number)
    {
        int result = count * count * count;
        Console.Write(result + " ");
        count++;
    }
}
Console.WriteLine("Здравствуйте!");
Console.Write("Введите число N и программа выдаст таблицу кубов чисел от 1 до N: ");
int number = Convert.ToInt32(Console.ReadLine());

CubsNumbers(number);
Console.WriteLine();
Console.Write("Хорошего вам дня! ;)");