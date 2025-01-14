namespace EstudosDeAlgoritmos
{
    public class InsertSort
    {
        public int[] SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                int insertElement = array[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (insertElement < array[j]) 
                    {
                        array[j + 1] = array[j];
                        i--;
                    }
                }
                array[i] = insertElement;
            }
            return array;
        }
    }
}
