/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

/* class Program 
{
public static void Main(string[]args)
{
   Console.Write("Введите числа : ");

   int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
   int count = 0;
   for (int i = 0; i < numbers.Length; i++)
     {
       if (numbers[i] > 0)
          {
             count++;
          }
     }
 
Console.WriteLine($"Числа, введенные пользователем,которые больше 0 = {count}");
}
} */




/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* 
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if(b1 == b2 && k1 == k2)
 {
    Console.WriteLine("Прямые совпадают");

}
     else if(k1 == k2)
  {
    Console.WriteLine("Прямые параллельные");
  }
else
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения двух прямых = ({x};{y})");
}

 */