// https://en.wikipedia.org/wiki/Bubble_sort
Console.WriteLine("Bubble Sort");

var array = new[] {3, 9, 1, 42, 10};
var flag = true;

for (int j = 0; j <= array.Length - 2 && flag; j++)
{
    flag = false;
    for (int i = 0; i <= array.Length - 2; i++)
    {
        if (array[i] > array[i + 1])
        {
            (array[i + 1], array[i]) = (array[i], array[i + 1]);
            flag = true;
        }
    }
}

Console.WriteLine(string.Join(",", array));
Console.ReadKey();