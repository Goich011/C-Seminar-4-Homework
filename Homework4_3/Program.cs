//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];
int index = 0;

while (index < 8)
{
    array[index] = Convert.ToInt32(Console.ReadLine());
    index++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
