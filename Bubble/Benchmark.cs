using BenchmarkDotNet.Attributes;

namespace Bubble;

[MemoryDiagnoser]
public class BenchmarkDemo
{
    private readonly int[] array = { 3, 9, 1, 42, 10 };

    [Benchmark]
    public void While()
    {
        var flag = true;
        while (flag)
        {
            flag = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    (array[i + 1], array[i]) = (array[i], array[i + 1]);
                    flag = true;
                }
            }
        }
    }

    [Benchmark]
    public void For()
    {
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
    }
}