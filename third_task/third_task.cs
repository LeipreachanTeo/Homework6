int N = new Random().Next(4,10);
int[] array = new int[N];
int sum = 0;

for(int i =0; i < array.Length; i++)
{
    array[i] = new Random().Next(1 ,10);
    Console.WriteLine(array[i]);
}

for(int i = 0; i <= array.Length/2 -1; i++)
{
    sum += array[i] * array[array.Length - i - 1];
    Console.WriteLine("+");
}
Console.WriteLine($"Сумма ровна: {sum}");
