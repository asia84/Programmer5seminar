/*32/Замена элементов массива:положительные элементы 
замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] ->[4, 8, -8, -2]
*/
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{ 
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
for(int i = 0; i < array.Length; i++)
//(int i = 0; i < 4; i++)
{
    array[i] = array[i] * (-1);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");//красиво выводим массив без использования цикла
//Console.WriteLine();
