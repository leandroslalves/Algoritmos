
using EstudosDeAlgoritmos;

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var insertIndex = new InsertIndex();

var result = insertIndex.Insert(array, 17, 4);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

