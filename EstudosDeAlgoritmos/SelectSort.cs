namespace EstudosDeAlgoritmos
{
    public class SelectSort
    {
        public int[] SortArray(int[] array)
        {
            var arrayLength = array.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;

                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }

                var tempVar = array[smallestVal];
                array[smallestVal] = array[i];
                array[i] = tempVar;
            }
            return array;
        }
    }
}
