using EstudosDeAlgoritmos;

int[] array = { 90, 70, 50, 80, 60 };

var insert = new InsertSort();

var result = insert.SortArray(array);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
