Console.WriteLine("Insertion Sort");

int[] array = {110, 1, 21, 53, 8, 98, 26, 163, 38, 897};

int i;
for (i = 1; i < array.Length; i++) 
{ 
    var key = array[i]; 
    var j = i - 1;
    while (j >= 0 && array[j] > key) 
    { 
        array[j + 1] = array[j]; 
        j -= 1; 
    } 
    array[j + 1] = key; 
} 

Console.WriteLine(string.Join(",", array));
Console.ReadKey();