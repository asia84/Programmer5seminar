/*33/Задайте массив. Напишите программу,которая определяет,
 присутствует ли данное число в массиве:
4; массив [6, 7, 9, 5, -3,]-> нет
-3; массив [6, 7, -3, 2, 1]-> да
*/
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{ 
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите число: ");
int number;
bool log  = false;
number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{ 
    if(number == array[i])//число равно числу массива
    {
        log = true;//число совпадает
        break;//выходим из цикла
    }
}
if (log)
{
    Console.WriteLine("Вот оно наконец-то!");
}
else
{
    Console.WriteLine("Этого числа в массиве нет..");
}

