using EstudosDeAlgoritmos;

int[] array = { 90, 70, 50, 80, 60, 85, 123, 111, 7, 23, 17 };

var selectSort = new SelectSort();

var result = selectSort.SortArray(array);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
