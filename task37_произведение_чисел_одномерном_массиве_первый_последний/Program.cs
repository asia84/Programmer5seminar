int n;
Console.WriteLine("Напишите количество чисел в массиве: ");
n = Convert.ToInt32(Console.ReadLine());
int[]array = new int [n];
Console.WriteLine("Напишите числа: ");
for(int i = 0; i < array.Length; i++)
{ 
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < array.Length / 2 + 0.5 ; i++)
{ 
    Console.WriteLine(array[i] * array[array.Length - i - 1]);
}