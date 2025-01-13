
using EstudosDeAlgoritmos;

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var removeIndex = new RemoveItemIndex();

var result = removeIndex.Remove(array, 5);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}

