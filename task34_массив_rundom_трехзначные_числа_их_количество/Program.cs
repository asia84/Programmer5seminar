/*34/Задайте массив, состоящий из трехзначных чисел,напишите программу,
 которая напишет количество четных чисел в массиве
 [345,897,568,234]->2
 */
int[] array = new int[25];//количество в массиве
for (int i = 0; i < 25; i++)
{ 
    array[i] = new Random().Next(100, 1000);//взяли разбег трехзначных чисел
}
Console.WriteLine("[" + string.Join(", ", array) + "]");//красиво оформили массив
int evenNumbersCount = 0;//количество четных чисел
for(int i = 0; i < 25; i++)
{
    if( array[i] % 2 == 0)
    {
        evenNumbersCount++;
    }  
}
Console.WriteLine("Количество четных чисел: " + evenNumbersCount);//красиво выводим массив без использования цикла
Console.WriteLine();
