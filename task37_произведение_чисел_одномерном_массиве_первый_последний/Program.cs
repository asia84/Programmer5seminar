int n;
Console.WriteLine("Напишите количество чисел в массиве: ");
n = Convert.ToInt32(Console.ReadLine());
int[]array = new int [n];
Console.WriteLine("Напишите числа: ");
for(int i = 0; i < array.Length; i++)
{ 
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int len;
if(n % 2 == 0) len = n / 2 - 1;
else len = n / 2;
for(int i = 0; i <= len  ; i++)

//for(int i = 0; i <= array.Length / 2 ; i++)
{ 
    Console.WriteLine(array[i] * array[array.Length - i - 1]);
}





/*
int n;
Console.WriteLine("Напишите кол-во чисел: ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Напишите числа: ");
for (int i = 0; i < array.Length; i++)
{
array[i] = Convert.ToInt32(Console.ReadLine());
}
int len;
if (n % 2 == 0){
len = n / 2 - 1;
}
else {len = n / 2;}
for (int i = 0; i <= len; i++)
{
Console.WriteLine(array[i] * array[array.Length - i - 1]);
}
*/