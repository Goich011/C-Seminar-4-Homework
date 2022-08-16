//задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Напиши число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напиши в какую степень возвести первое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;

for (int i = 0; i < b; i++)
{
    count = (count * a);
}
Console.Write(a);
Console.Write(" в степени ");
Console.Write(b);
Console.Write(" = ");
Console.WriteLine(count);