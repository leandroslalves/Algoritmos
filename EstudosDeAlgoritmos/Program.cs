using EstudosDeAlgoritmos;

int[] array = GenerateRandomNumber(10);

Console.Write("Array desordenado: ");
MostrarArray(array);

Console.WriteLine("\n\n-----------------------------------------------------");

var merge = new MergeSort();

var result = merge.SortArray(array, 0, array.Length - 1);

Console.Write("\n\nArray ordenado: ");
MostrarArray(result);
Console.WriteLine("");

static int[] GenerateRandomNumber(int size)
{
    var array = new int[size];
    var rand = new Random();
    var maxNum = 10000;

    for (int i = 0; i < size; i++)
        array[i] = rand.Next(maxNum + 1);

    return array;
}

static void MostrarArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
}
