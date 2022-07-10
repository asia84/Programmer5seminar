/*32/Замена элементов массива:положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] ->[4, 8, -8, -2]
*/
int[] array = new int[4];
for (int i = 0; i < 4; i++)
{ 
  array[i] = new Random().Next(-9, 10);  
}
//Console.WriteLine();
Console.WriteLine("[" + string.Join(", ", array) + "]");
for(int i = 0; i < 4; i++)
{
    array[i] = array[i] * (-1);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");//красиво выводим массив без использования цикла
//Console.WriteLine();

