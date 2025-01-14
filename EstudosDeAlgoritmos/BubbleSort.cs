
namespace EstudosDeAlgoritmos
{
    public class BubbleSort
    {
        public static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isSwap = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isSwap = true;
                    }
                }
                if (!isSwap)
                {
                    break;
                }
            }
        }
    }
}
