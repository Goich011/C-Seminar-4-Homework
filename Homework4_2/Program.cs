//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Напиши число а я посчитаю сумму цифр в числе: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count = a.ToString().Length;

for (int i= 0; i < count; i++)
{
    int curr = a % 10;
    a = a / 10;
    sum = sum + curr;
}
Console.WriteLine(sum);