// https://en.wikipedia.org/wiki/Radix_sort#Least_significant_digit_radix_sorts
Console.WriteLine("Radix Sort");

int[] array = {110, 1, 21, 53, 8, 98, 26, 163, 38, 897};
var max = array.Max();
for (var exp = 1; max / exp > 0; exp *= 10)
    Sort(array, array.Length, exp);

Console.WriteLine(string.Join(",", array));

static void Sort(IList<int> array, int length, int exponent)
{
    int[] output = new int[length];
    int i;

    int[] count = new int[10];
    for (i = 0; i < 10; i++)
    {
        count[i] = 0;
    }
    for (i = 0; i < length; i++)
    {
        count[(array[i] / exponent) % 10]++;
    }
    for (i = 1; i < 10; i++)
    {
        count[i] += count[i - 1];
    }
    for (i = length - 1; i >= 0; i--)
    {
        output[count[(array[i] / exponent) % 10] - 1] = array[i];
        count[(array[i] / exponent) % 10]--;
    }
    for (i = 0; i < length; i++)
    {
        array[i] = output[i];
    }
}

Console.ReadLine();