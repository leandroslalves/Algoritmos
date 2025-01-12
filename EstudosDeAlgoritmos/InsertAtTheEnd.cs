namespace EstudosDeAlgoritmos
{
    public class InsertAtTheEnd
    {
        public int[] Add(int[] array, int value)
        {
            int[] tempArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[tempArray.Length - 1] = value;

            return tempArray;
        }
    }
}
