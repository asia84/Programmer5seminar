/*void factorial( int[] n)
{
    int count = 1;
    for(int i = 1;i <=n;i++)
    {
        count = count * i;
    }
Console.WriteLine(count);
}

factorial(5);
*/



int factorial( int n)
{
    int count = 1;
    for (int i = 1; i <= n; i++)
    {
        count = count * i;
    }
    return count;
}
int result;
result = factorial(5);
Console.WriteLine(result);