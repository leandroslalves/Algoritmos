namespace EstudosDeAlgoritmos
{
    public class RemoveItemIndex
    {
        public int[] Remove(int[] array, int index)
        {
            int[] tempArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < index)
                {
                    tempArray[i] = array[i];
                }
                if (i > index)
                {
                    tempArray[i - 1] = array[i];
                }
            }

            return tempArray;
        }
    }
}
