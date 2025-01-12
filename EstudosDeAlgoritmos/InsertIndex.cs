namespace EstudosDeAlgoritmos
{
    public class InsertIndex
    {
        public int[] Insert(int[] array, int value, int insertIndex)
        {
            var tempArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < insertIndex)
                {
                    tempArray[i] = array[i];
                }
                else
                {
                    tempArray[i + 1] = array[i];
                }
            }

            tempArray[insertIndex] = value;

            return tempArray;
        }
    }
}
