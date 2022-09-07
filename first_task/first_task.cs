Console.WriteLine("Введите количество чисел которые нужно ввести: ");
int M = Int16.Parse(Console.ReadLine());
int [] array = new int[M];
int i = 0;
int count = 0;

while(i < array.Length)
{   
    Console.WriteLine("Введите число: ");
    array[i] = Int16.Parse(Console.ReadLine());
    if (array[i] > 0)
    {
        count++;
    }
i++;
}
Console.Write("Количество чисел которые больше 0 : ");
Console.WriteLine(count);